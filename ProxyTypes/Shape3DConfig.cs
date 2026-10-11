using UnityEngine;
#if MCELoader
using Il2CppQuantum;
#endif
namespace MCELoader.Shared.ProxyTypes
{




#if MCELoader
    [SourceType(typeof(Il2CppQuantum.Shape3DConfig))]
#endif
    public class Shape3DConfig
    {
        public struct CompoundShapeData3D
        {
            public Shape3DType ShapeType;
            public float SphereRadius;
            public float CapsuleRadius;
            public float CapsuleHeight;
            public Vector3 PositionOffset;
            public Vector3 BoxExtents;
            public Vector3 RotationOffset;
            public ushort UserTag;
            public bool IsSetFromSourceCollider;
#if MCELoader
            public Il2CppQuantum.Shape3DConfig.CompoundShapeData3D ToQNative()
            // codegen cant handle source types that are nested ig
            {
                return new()
                {
                    ShapeType = this.ShapeType,
                    SphereRadius = this.SphereRadius,
                    CapsuleRadius = this.CapsuleRadius,
                    CapsuleHeight = this.CapsuleHeight,

                    PositionOffset = this.PositionOffset.ToFPVector3(),
                    BoxExtents = this.BoxExtents.ToFPVector3(),
                    RotationOffset = this.RotationOffset.ToFPVector3(),

                    UserTag = this.UserTag,
                    IsSetFromSourceCollider = this.IsSetFromSourceCollider,
                };
            }
#endif
        }

        public Shape3DType ShapeType;
        public float SphereRadius;
        public float CapsuleRadius;
        public float CapsuleHeight;
        public Vector3 PositionOffset;
        public Vector3 BoxExtents;
        public Vector3 RotationOffset;
        public ushort UserTag;
        public bool IsPersistent = true;
        public CompoundShapeData3D[] CompoundShapes = new CompoundShapeData3D[0];

    }
}
