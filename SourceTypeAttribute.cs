namespace MCELoader.Shared
{
#if MCELoader
    public class SourceTypeAttribute : System.Attribute
    {
        public SourceTypeAttribute(Type source) { }

    }
#endif
}
