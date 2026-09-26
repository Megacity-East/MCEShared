using UnityEngine;
#if MCELoader
using Il2CppQuantum;
#endif
namespace MCELoader.Shared.ProxyTypes
{
#if MCELoader
    [SourceType(typeof(Il2CppQuantum.MapConfig))]
#endif
    public class MapConfig : IAssetObject
    {
#if MCEEditor
        public enum PoliceSpawn
        {
            NO_POLICE = -1,
            TwoThirdsScore = 0,
            TwoThirdsScoreAndTrigger = 1,
            HalfScore = 2,
        }
#endif
        public SpawnPointWithOrientation devSpawn;
        public SpawnPointWithOrientation[] spawnPoints = new SpawnPointWithOrientation[0];
        public SpawnPointWithDistance[] checkPoints = new SpawnPointWithDistance[0];
        public Vector3[] itemSpawnPoints = new Vector3[0];
        public ConsumablePoint[] consumables = new ConsumablePoint[0];
        public Vector3[] stragglerBoostPoints = new Vector3[0];
        public SpecialEquipmentSpawnPoint[] specialEquipmentSpawnPoints = new SpecialEquipmentSpawnPoint[0];
        public EventTriggerEntry[] eventTriggerEntries = new EventTriggerEntry[0];
        public MutableStaticColliderEntry[] mutableStaticColliderEntries = new MutableStaticColliderEntry[0];
        public PathConnectedCollider[] pathConnectedColliders = new PathConnectedCollider[0];
        public Arena[] arenas = new Arena[0];
        public NoBikesZone[] noBikesZones = new NoBikesZone[0];
        public CurvePath mainPath;
        public CurvePath[] miscPaths = new CurvePath[0];
        public int[] variableWaterLevelColliders = new int[0];
        public int[] variableWaterfallColliders = new int[0];
        public int[] variableWaterSprayColliders = new int[0];
        public DestructibleTerrainData[] destructibleTerrain = new DestructibleTerrainData[0];
        public int[] destructibleTerrainColliders = new int[0];
        public HeliPathConnection[] heliPathConnections = new HeliPathConnection[0];
        public RoadData[] roads = new RoadData[0];
        //        public LevelID levelID; // HACK/TODO inbound, im probably gonna reuse the map manifest guids but as fucky ints?
#if MCEEditor
        public PoliceSpawn policeSpawnbehaviour;
#else
        public Il2CppQuantum.MapConfig.PoliceSpawn policeSpawnbehaviour;
#endif
        public float carSpawnRateFactor;
        public float trucksPercent;
        public float checkpointSpawnRateFactor;
        public CurvePathSerializableData pathDataSerializable; //HACK/TODO this is private in the proxied type!!!!!!!!, should probably use bepinex publizier??
        // public CurvePathData pathData; // NOTE: CurvePathData has a constructor that takes in CurvePathSerializableData,
    }
}
