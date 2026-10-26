namespace MCELoader.Shared.ProxyTypes
{
    public abstract class ComponentPrototype
    {
#if MCELoader
        public abstract Il2CppQuantum.ComponentPrototype GetQNative();

        public virtual Il2CppQuantum.ComponentPrototype ToQNative() => GetQNative();
#endif
    }
}
