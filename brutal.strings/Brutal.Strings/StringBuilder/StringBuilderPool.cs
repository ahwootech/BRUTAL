using System.Numerics;
using Microsoft.Extensions.ObjectPool;

namespace Brutal.Strings;

/// <summary>
/// A pool of <see cref="StringBuilder{TChar}"/> instances for efficient reuse.
/// Thread-safe.
/// StringBuilders with bloated capacity are dropped on return to conserve memory.
/// </summary>
/// <typeparam name="TChar">byte (UTF-8) or char (UTF-16)</typeparam>
public class StringBuilderPool<TChar> : DefaultObjectPool<StringBuilder<TChar>>
    where TChar : unmanaged, IBinaryInteger<TChar>
{
    private static readonly StringBuilderPolicy Policy = new();

    private sealed class StringBuilderPolicy : IPooledObjectPolicy<StringBuilder<TChar>>
    {
        public StringBuilder<TChar> Create() => new();

        public bool Return(StringBuilder<TChar> sb)
        {
            if (ByteSize.Of<TChar>(sb.Capacity) > ByteSize.FromKilobytes(4))
                return false; // drop bloated instances

            sb.ResetToDefault();
            return true;
        }
    }

    public static readonly StringBuilderPool<TChar> Shared = new();

    public StringBuilderPool()
        : base(Policy) { }

    public StringBuilderPool(int maximumRetained)
        : base(Policy, maximumRetained) { }

    public StringBuilderPool(IPooledObjectPolicy<StringBuilder<TChar>> policy)
        : base(policy) { }

    public StringBuilderPool(IPooledObjectPolicy<StringBuilder<TChar>> policy, int maximumRetained)
        : base(policy, maximumRetained) { }
}
