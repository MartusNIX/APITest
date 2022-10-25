using Newtonsoft.Json;

namespace APITest.Models
{
    public class DataEmployeeModel
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("salary")]
        public string salary { get; set; }

        [JsonProperty("age")]
        public string age { get; set; }

        [JsonProperty("image")]
        public string image { get; set; }
    }
}
