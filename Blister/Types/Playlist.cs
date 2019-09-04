using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Blister.Types
{
    public struct Playlist
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("cover")]
        public byte[] Cover { get; set; }

        [JsonProperty("maps")]
        public List<Beatmap> Maps { get; set; }
    }
}
