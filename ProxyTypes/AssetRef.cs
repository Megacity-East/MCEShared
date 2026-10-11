#if MCELoader
using Il2CppQuantum;
using MCELoader.Extensions;
#endif

namespace MCELoader.Shared.ProxyTypes
{

    public struct AssetRef
    {
        public long Id;

        public AssetRef(long id)
        {
            Id = id;
        }

#if MCELoader
        public Il2CppQuantum.AssetRef ToQNative()
        {
            return new() { Id = new Il2CppQuantum.AssetGuid(this.Id) };
        }
#endif

    }

    public struct AssetRef<T>
#if MCELoader
      where T : Il2CppQuantum.AssetObject
#endif
    {
        public long Id;

#if MCELoader
        public Il2CppQuantum.AssetRef<T> ToQNative()
        {
            return new() { Id = new Il2CppQuantum.AssetGuid(this.Id) };
        }
#endif

    }
}
