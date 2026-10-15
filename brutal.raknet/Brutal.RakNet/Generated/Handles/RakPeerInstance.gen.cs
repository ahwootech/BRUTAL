namespace Brutal.RakNetApi
{
    public unsafe partial struct RakPeerInstance(nint impl) : INullable, IDisposable
    {
        public bool IsNull() => impl is 0;

        internal nint Impl => impl;

        public void Dispose()
        {
            if (impl is not 0)
            {
                RakPeerInterface.DestroyInstance(this);
                impl = 0;
            }
        }
    }
}
