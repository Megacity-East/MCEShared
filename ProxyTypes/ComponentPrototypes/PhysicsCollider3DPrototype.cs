using UnityEngine;

namespace MCELoader.Shared.ProxyTypes.ComponentPrototypes
{

#if MCELoader
    [SourceType(typeof(Il2CppQuantum.Prototypes.PhysicsCollider3DPrototype))]
#endif
    public class PhysicsCollider3DPrototype : ComponentPrototype
    {
        public bool IsTrigger;
        public int Layer;
#if MCELoader
        public AssetRef<Il2CppQuantum.PhysicsMaterial> PhysicsMaterial;
#else
        public AssetRef PhysicsMaterial;
#endif
        public Shape3DConfig ShapeConfig;

#if MCELoader
        public override Il2CppQuantum.ComponentPrototype GetQNative()
        {
            return MCELoader.Extensions.GeneratedExtensions.ToQNative(this);
        }
#endif
    }
}
