﻿using Newtonsoft.Json;

namespace aurelia_2.Middleware
{
    public class JsonWebToken
    {
        [JsonProperty("iss")]
        public string Issuer { get; set; }

        [JsonProperty("sub")]
        public string Subject { get; set; }

        [JsonProperty("aud")]
        public string Audience { get; set; }

        [JsonProperty("exp")]
        public long Expiry { get; set; }

        [JsonProperty("iat")]
        public long IssuedAt { get; set; }
    }
}
