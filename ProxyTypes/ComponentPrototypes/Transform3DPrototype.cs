using UnityEngine;

namespace MCELoader.Shared.ProxyTypes.ComponentPrototypes
{


#if MCELoader
    [SourceType(typeof(Il2CppQuantum.Prototypes.Transform3DPrototype))]
#endif
    public class Transform3DPrototype : ComponentPrototype
    {
        public Vector3 Position;
        public Vector3 Rotation;

#if MCELoader
        public override Il2CppQuantum.ComponentPrototype GetQNative()
        {
            return MCELoader.Extensions.GeneratedExtensions.ToQNative(this);
        }
#endif
    }

}
