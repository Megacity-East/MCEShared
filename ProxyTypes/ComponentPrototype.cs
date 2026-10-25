namespace MCELoader.Shared.ProxyTypes
{
    public abstract class ComponentPrototype
    {
#if MCELoader
        public Il2CppQuantum.ComponentPrototype ToQNative()
        {
            throw new NotImplementedException();
        }
#endif
    }
}
