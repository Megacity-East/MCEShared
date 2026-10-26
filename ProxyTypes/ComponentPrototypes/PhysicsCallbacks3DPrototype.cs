using UnityEngine;
#if MCELoader
using Il2CppQuantum;
#endif
namespace MCELoader.Shared.ProxyTypes.ComponentPrototypes
{

#if MCEEditor
    [System.Flags]
    public enum CallbackFlags
    {
        None = 0,
        OnDynamicCollision = 1,
        OnDynamicCollisionEnter = 2,
        OnDynamicCollisionExit = 4,
        OnStaticCollision = 8,
        OnStaticCollisionEnter = 16,
        OnStaticCollisionExit = 32,
        OnDynamicTrigger = 64,
        OnDynamicTriggerEnter = 128,
        OnDynamicTriggerExit = 256,
        OnStaticTrigger = 512,
        OnStaticTriggerEnter = 1024,
        OnStaticTriggerExit = 2048,
    }
#endif

#if MCELoader
    [SourceType(typeof(Il2CppQuantum.Prototypes.PhysicsCallbacks3DPrototype))]
#endif
    public class PhysicsCallbacks3DPrototype : ComponentPrototype
    {

        public CallbackFlags CallbackFlags;

#if MCELoader
        public override Il2CppQuantum.ComponentPrototype GetQNative()
        {
            return MCELoader.Extensions.GeneratedExtensions.ToQNative(this);
        }
#endif
    }
}
