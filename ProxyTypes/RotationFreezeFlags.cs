namespace MCELoader.Shared.ProxyTypes
{
#if MCEEditor
    [System.Flags]
    public enum RotationFreezeFlags
    {
        None = 0,
        FreezeX = 1,
        FreezeY = 2,
        FreezeZ = 4,
        FreezeAll = 7,
    }
#endif
}
