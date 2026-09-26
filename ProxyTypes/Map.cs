namespace MCELoader.Shared.ProxyTypes
{

    // TODO need to implement this, probably?, i really have no fucking clue how though qwq
    // NOTE: look into DynamicMap, it inherits from Map, so it could be interesting...
#if MCELoader
[SourceType(typeof(Il2CppQuantum.Map))]
#endif
    public class Map : IAssetObject
    {
#if MCEEditor
        public enum BucketAxis
        {
            X = 0,
            Y = 1,
        }
        public enum SortAxis
        {
            X = 0,
            Y = 1,
        }
#endif
        // public AssetRef UserAsset; 
        public string Scene;
        public string ScenePath;
        public string SceneGuid;

        public int WorldSize;
        public int BucketsCount;
        public int BucketsSubdivisions;
#if MCEEditor
        public Map.BucketAxis BucketingAxis;  // TODO figure out what this is used for, leaning navmesh
        public Map.SortAxis SortingAxis;  // TODO figure out what this is used for, leaning navmesh
#else
        public Il2CppQuantum.PhysicsCommon.BucketAxis BucketingAxis; // TODO figure out what this is used for, leaning navmesh
        public Il2CppQuantum.PhysicsCommon.SortAxis SortingAxis;  // TODO figure out what this is used for, leaning navmesh
#endif
        public float SceneMeshCellSize;
        public int TriangleMeshCellSize;

        //    public AssetRef<BinaryData> StaticColliders3DTrianglesData; 

        public bool SerializeTrianglesMetadata;
        public int GridSizeX;  // NOTE: seems to be irelevant to fill, only used for navmeshes which as of build 42 is unused
        public int GridSizeY;  //NOTE: navmesh related
        public int GridNodeSize; //NOTE: navmesh related

        //    public AssetRef<NavMesh>[] NavMeshLinks; //Field offset: 0x80 //NOTE: navmesh related
        // public string[] Regions; //Field offset: 0x88 // NOTE: also always empty

        //    public MapStaticCollider2D[] StaticColliders2D; // NOTE: Always Empty 
        public MapStaticCollider3D[] StaticColliders3D = new MapStaticCollider3D[0];
        public ComponentPrototypeSet[] MapEntities = new ComponentPrototypeSet[0];
        public int SerializedTriangleDataUncompressedSize;

        //    public SortedDictionary<int, MeshTriangleVerticesCcw> CollidersManagedTriangles; // NOTE: I think this is set by the collider mesh loading
        //    public SortedDictionary<int, MeshUnmanagedTrianglesRef> CollidersRuntimeTriangles;

        // public UnmanagedTriangleArray AllRuntimeTriangles; // NOTE: ABSOLUTELY ZERO CLUE HOW TO WORK WITH THIS

        //    public List<PolygonColliderRuntimeData> StaticPolygonColliderData; 
        //    public Dictionary<string, NavMesh> NavMeshes; //NOTE: navmesh related
        //    public Dictionary<string, int> RegionMap;  //NOTE: unused so :3
    }
}
