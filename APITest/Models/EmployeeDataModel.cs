using Newtonsoft.Json;

namespace APITest.Models
{
    public class EmployeeDataModel
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("salary")]
        public string salary { get; set; }

        [JsonProperty("employee_age")]
        public string age { get; set; }

        [JsonProperty("image")]
        public string image { get; set; }
    }
}
