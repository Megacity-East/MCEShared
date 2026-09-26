using UnityEngine;
namespace MCELoader.Shared.ProxyTypes
{

#if MCELoader
    using Il2CppQuantum;
    [SourceType(typeof(Il2CppQuantum.MapStaticCollider3D))]
#endif
    public struct MapStaticCollider3D
    {
        public Quaternion Rotation; //Field offset: 0x0
        public Vector3 Position; //Field offset: 0x20

#if MCELoader
        public AssetRef<Il2CppQuantum.PhysicsMaterial> PhysicsMaterial;
#else
        public AssetRef PhysicsMaterial;
#endif

        public Shape3DType ShapeType; //Field offset: 0x40
        public float SphereRadius; //Field offset: 0x48
        public float CapsuleRadius; //Field offset: 0x50
        public float CapsuleHeight; //Field offset: 0x58
        public Vector3 BoxExtents; //Field offset: 0x60
        public bool SmoothSphereMeshCollisions; //Field offset: 0x78
        public StaticColliderData StaticData; //Field offset: 0x80
    }
}
