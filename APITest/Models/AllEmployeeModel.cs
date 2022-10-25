using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APITest.Models
{
    public class AllEmployeeModel
    {
        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("data")]
        public List<EmployeeDataModel> data { get; set; }

        [JsonProperty("message")]
        public string message { get; set; }
    }
}
