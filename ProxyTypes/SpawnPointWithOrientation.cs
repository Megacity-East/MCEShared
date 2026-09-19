using UnityEngine;
namespace MCELoader.Shared.ProxyTypes
{
#if MCELoader
    [SourceType(typeof(Il2CppQuantum.SpawnPointWithOrientation))]
#endif
    public struct SpawnPointWithOrientation
    {
        public Vector3 position;
        public float degreesOnY;
    }

}
