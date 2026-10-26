using UnityEngine;

namespace MCELoader.Shared.ProxyTypes.ComponentPrototypes
{
#if MCELoader
    [SourceType(typeof(Il2CppQuantum.Prototypes.StartLineGatePrototype))]
#endif
    public class StartLineGatePrototype : ComponentPrototype
    {
        public int arena;
        public bool goalUp;
        public bool awake;
        public float up;
        public Vector3 baseRotation;
        public Vector2 timeStamps;

#if MCELoader
        public override Il2CppQuantum.ComponentPrototype GetQNative()
        {
            return MCELoader.Extensions.GeneratedExtensions.ToQNative(this);
        }
#endif
    }
}
