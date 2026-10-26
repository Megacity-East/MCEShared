using UnityEngine;
#if MCELoader
using Il2CppQuantum;
using Il2CppQuantum.Prototypes;
#endif
namespace MCELoader.Shared.ProxyTypes.ComponentPrototypes
{

#if MCELoader
    [SourceType(typeof(Il2CppQuantum.Prototypes.PhysicsBody3DPrototype))]
#endif
    public class PhysicsBody3DPrototype : ComponentPrototype
    {

        public PhysicsBody3D.ConfigFlags Config;
        public float Mass;
        public float Drag;
        public float AngularDrag;
        public Vector3 CenterOfMass;
        public RotationFreezeFlags RotationFreeze;
        public float? GravityScale;
        public float? InertiaScale;
        public PhysicsBodyInertiaMode InertiaMode;
        public Vector3 ExplicitInertiaTensor;
        public Shape3DConfig ParametricInertiaShape;


#if MCELoader
        public override Il2CppQuantum.ComponentPrototype GetQNative()
        {
            return MCELoader.Extensions.GeneratedExtensions.ToQNative(this);
        }
#endif
    }
}
