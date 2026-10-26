namespace MCELoader.Shared.ProxyTypes
{

#if MCEEditor
///<remarks>Currently this type just exists to house its enums.</remarks>
public struct PhysicsBody3D
{
    [Flags]
    public enum ConfigFlags
    {
        Default = 58,
        IsKinematic = 1,
        IsAllowedToSleep = 2,
        IsAwakenedByForces = 32,
        IsAwakenedByKinematics = 4,
        ResetInertiaOnAdded = 8,
        ResetCenterOfMassOnAdded = 16,
        UseContinuousCollisionDetection = 64,
    }
}
#endif

}

