﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CorePush.Utils
{
    public static class JsonHelper
    {
        private static JsonSerializerSettings settings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        public static string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, settings);
        }

        public static TObject Deserialize<TObject>(string json)
        {
            return JsonConvert.DeserializeObject<TObject>(json, settings);
        }
    }
}
