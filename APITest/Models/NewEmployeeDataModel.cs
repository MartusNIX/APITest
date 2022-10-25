using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APITest.Models
{
    public class NewEmployeeDataModel
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("salary")]
        public string salary { get; set; }

        [JsonProperty("age")]
        public string age { get; set; }

        [JsonProperty("message")]
        public string message { get; set; }
    }
}
