using Newtonsoft.Json;

namespace APITest.Models
{
    public class EmployeeModel
    {
        [JsonProperty("id")]
        public string id { get; set; }

        public string employee_name { get; set; }

        public string employee_salary { get; set; }

        public string employee_age { get; set; }

        public string profile_image { get; set; }

        public string message { get; set; }
    }
}
