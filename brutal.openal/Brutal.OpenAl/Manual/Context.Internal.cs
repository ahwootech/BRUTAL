// The internal half of Context (public half: Context.cs): the weak ledger mapping native context
// addresses back to the wrappers this layer created, and the eviction pair Device.Dispose drives
// when closing a device destroys the live contexts on it.

using System.Collections.Concurrent;

namespace Brutal.OpenAlApi;

public sealed partial class Context
{
    // Ledger of live wrappers keyed by native address. AlcContext.Handle is the generated record
    // struct, so the default comparer is value-based and non-boxing. Registered in the ctor, removed
    // in Dispose; entries for leaked wrappers die with their targets and are pruned on the next
    // registration.
    private static readonly ConcurrentDictionary<AlcContext.Handle, WeakReference<Context>> LiveContexts = new();

    // Closing a device natively destroys any live contexts on it without their Dispose running -
    // the one path that frees a context's address while its ledger entry survives, after which a
    // recycled address would resolve to the stale wrapper and make Current lie. Device.Dispose
    // calls this BEFORE the native close, so a freed address is never mapped; if the close then
    // fails, the evicted contexts merely stop resolving (a miss, never a lie).
    internal static List<Context> EvictDeviceEntries(Device device)
    {
        List<Context> orphans = [];

        foreach (var entry in LiveContexts)
        {
            // Removing by (key, value) pair, as in the ctor prune, never evicts a re-registered
            // entry. Both arms evict and prune any rooted callback handlers keyed by the address;
            // they differ only in whether a live wrapper survives for MarkOrphaned below.
            if (!entry.Value.TryGetTarget(out var context))
            {
                LiveContexts.TryRemove(entry);
                Al.EvictContextRoots(entry.Key.Value);
            }
            else if (ReferenceEquals(context.Device, device))
            {
                LiveContexts.TryRemove(entry);
                Al.EvictContextRoots(entry.Key.Value);
                orphans.Add(context);
            }
        }

        return orphans;
    }

    // The native contexts are gone, so their wrappers must stop claiming to hold one - otherwise
    // every later call on them (Dispose included) targets a freed address. Device.Dispose calls
    // this only AFTER the close succeeds; on failure the contexts are still alive natively, and
    // invalidating their wrappers would strand them.
    internal static void MarkOrphaned(List<Context> orphans)
    {
        foreach (var context in orphans)
            context.Handle = AlcContext.Null;
    }
}
