namespace Brutal.RakNetApi;

public partial struct AddressOrGUID
{
    public static AddressOrGUID UnassignedGuid => new(RakNetGUID.UNASSIGNED_RAKNET_GUID);

    public static AddressOrGUID From(RakNetGUID guid) => new(guid);

    public static AddressOrGUID From(SystemAddress address) => new(address);

    public AddressOrGUID(RakNetGUID guid)
    {
        RakNetGuid = guid;
        SystemAddress = SystemAddress.UNASSIGNED_SYSTEM_ADDRESS;
    }

    public AddressOrGUID(SystemAddress systemAddress)
    {
        SystemAddress = systemAddress;
        RakNetGuid = RakNetGUID.UNASSIGNED_RAKNET_GUID;
    }

    public string ToString(bool appendPort = false, char delimiter = ':')
    {
        return RakNetGuid != RakNetGUID.UNASSIGNED_RAKNET_GUID
            ? RakNetGuid.ToString()
            : SystemAddress.ToString(appendPort, delimiter);
    }
}

/*public readonly unsafe partial struct RakPeerInstance : IDisposable
{
    public void Dispose()
    {
        if (impl != 0)
        {
            RakNetLibrary.DestroyInstance(this);
        }
    }
}*/
