using Newtonsoft.Json;

namespace APITest.Models
{
    public class DataEmployeeModel
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("employee_name")]
        public string name { get; set; }

        [JsonProperty("employee_salary")]
        public string salary { get; set; }

        [JsonProperty("employee_age")]
        public string age { get; set; }

        [JsonProperty("profile_image")]
        public string image { get; set; }
    }
}
