using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APITest.Models
{
    public class CreateEmployeeDataModel
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("salary")]
        public string salary { get; set; }

        [JsonProperty("age")]
        public string age { get; set; }
    }
}
