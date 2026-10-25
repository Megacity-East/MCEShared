#if MCELoader
using MCELoader.Extensions;
#endif

namespace MCELoader.Shared.ProxyTypes
{

    public struct ComponentPrototypeSet
    {
        public ComponentPrototype[] Components;

#if MCELoader
        public Il2CppQuantum.ComponentPrototypeSet ToQNative()
        {
            IEnumerable<Il2CppQuantum.ComponentPrototype> QNativeComponents = this.Components.Select(comp => comp.ToQNative());

            return Il2CppQuantum.ComponentPrototypeSet.FromArray(QNativeComponents.ToReferenceArray());
        }
#endif
    }
}
