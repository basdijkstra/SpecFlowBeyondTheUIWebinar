﻿using Newtonsoft.Json;

namespace SpecFlowBeyondTheUIWebinar.Models
{
    public class Account
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerId")]
        public int CustomerId { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("type")]
        public string AccountType { get; set; }
    }
}
