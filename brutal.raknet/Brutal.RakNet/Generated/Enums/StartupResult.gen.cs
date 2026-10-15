namespace Brutal.RakNetApi
{
    public enum StartupResult
    {
        RaknetStarted,
        RaknetAlreadyStarted,
        InvalidSocketDescriptors,
        InvalidMaxConnections,
        SocketFamilyNotSupported,
        SocketPortAlreadyInUse,
        SocketFailedToBind,
        SocketFailedTestSend,
        PortCannotBeZero,
        FailedToCreateNetworkThread,
        CouldNotGenerateGuid,
        StartupOtherFailure,
    }
}
