using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APITest.Models
{
    public class SingleEmployeeModel
    {
        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("data")]
        public EmployeeDataModel data { get; set; }

        [JsonProperty("message")]
        public string message { get; set; }
    }
}
