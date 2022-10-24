using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APITest.Models
{
    internal class SingleEmployeeModel
    {
        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("data")]
        public ICollection<EmployeeDataModel> data { get; set; }
    }
}
