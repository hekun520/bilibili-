﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Core.aria2cNet.client.entity
{
    [JsonObject]
    public class AriaChangeUri
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("result")]
        public List<int> Result { get; set; }

        [JsonProperty("error")]
        public AriaError Error { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
