using System;

namespace MCELoader.Shared
{

    public class MCEManifest
    {
        /// <summary>The name of the map</summary>
        public string Name;

        /// <summary>The display name of the map</summary>
        public string DisplayName;

        /// <summary>The authors of the map</summary>
        public string[] Authors;

        /// <summary>The version of the map</summary>
        /// <remarks>Should be semvar</remarks>
        public string Version = "0.0.0";

        /// <summary>Randomly generated guid, during map compile</summary>
        public string BuildId = Guid.NewGuid().ToString(); // This should be different everytime a map is compiled

        /// <summary>Randomly generated guid, should ideally remain constant across builds</summary>
        public string MapGuid;

        /// <summary>The version of MCE Editor this map was compiled with</summary>
        public string EditorVersion;

        /// <summary>The version of MCE Loader this map was compiled for</summary>
        public string TargetLoaderVersion;
    }
}

