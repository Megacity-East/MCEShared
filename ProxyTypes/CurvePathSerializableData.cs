using UnityEngine;
namespace MCELoader.Shared.ProxyTypes
{
#if MCELoader
    [SourceType(typeof(Il2CppQuantum.CurvePathSerializableData))]
#endif
    public struct CurvePathSerializableData
    {
        public Vector3[] allPoints;
        public float[] allCumulativeDistances;
        public float[] allRadii;
        public Vector3[] allTangents;
        public Vector3[] allNormals;
    }

}
