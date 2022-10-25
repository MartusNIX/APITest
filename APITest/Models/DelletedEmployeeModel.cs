using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APITest.Models
{
    internal class DelletedEmployeeModel
    {
        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("data")]
        public string data { get; set; }

        [JsonProperty("message")]
        public string message { get; set; }
    }
}
