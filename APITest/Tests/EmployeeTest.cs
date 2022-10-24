using APITest.Constants;
using APITest.Controllers;
using APITest.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using NUnit.Framework;
using NUnit.Framework.Internal.Commands;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;


namespace APITest.Tests
{
    [TestFixture]
    public class EmployeeTest : EmployeeController
    {
        [Test]
        public async Task CheckThatEmployeeControllerReturnsResponse()
        {
            //var response = await this.GetEmployeeAsync();
            //response.Should().NotBeNull("Response is null");
            var response = await this.GetEmployeeAsync();
            var jsonContent = JsonConvert.DeserializeObject<AllEmployeeModel>(response.Content);
            var actualStatus = jsonContent.status;
            var expectedStatus = ConfigConstants.ExpectedStatus;

            Assert.AreEqual(expectedStatus, actualStatus, "All Employees not found");
        }

        [Test]
        public async Task CheckThatEmployeeControllerReturnsResponseById()
        {
            var response = await this.GetEmployeeByIdAsync();
            
        }
    }
}
