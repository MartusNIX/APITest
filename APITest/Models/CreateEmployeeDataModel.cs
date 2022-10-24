using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APITest.Models
{
    internal class CreateEmployeeDataModel
    {
        [JsonProperty("employee_name")]
        public string employee_name { get; set; }

        [JsonProperty("employee_salary")]
        public string employee_salary { get; set; }

        [JsonProperty("employee_age")]
        public string employee_age { get; set; }
    }
}
