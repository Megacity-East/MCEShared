namespace MCELoader.Shared.ProxyTypes
{

    public struct AssetGuid
    {
        public long Id;

#if MCELoader
        public Il2CppQuantum.AssetGuid ToQNative()
        {
            return new(Id);
        }
#endif
    }

}
