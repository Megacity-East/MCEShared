#if MCELoader
using Il2CppQuantum;
using MCELoader.Extensions;
#endif

namespace MCELoader.Shared.ProxyTypes
{

    public struct AssetRef

    {
        public long Id;


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
            return new() { Id = new AssetGuid(this.Id) };
        }
#endif
    }
}
