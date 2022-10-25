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
            var jsonContent = JsonConvert.DeserializeObject<SingleEmployeeModel>(response.Content);
            var actualId = jsonContent.data.id;
            var expectedStatus = ConfigConstants.ExpectedId;

            Assert.AreEqual(expectedStatus, actualId, "User by ID not found");
        }

        [Test]
        public async Task CheckThatEmployeeControllerPostNewEmployee()
        {
            NewEmployeeDataModel model = new NewEmployeeDataModel();
            model.name = "Krol";
            model.salary = "5000";
            model.age = "29";
            var sentResponse = await this.PostEmployeeAsync(model);
            var jsonContent = JsonConvert.DeserializeObject<NewEmployeeDataModel>(sentResponse.Content);
            var actualMessage = jsonContent.message;
            var expectedMessage = ConfigConstants.SuccessMessagePOST;
            Assert.AreEqual(expectedMessage, actualMessage, "User not created");
        }

        [Test]
        public async Task CheckThatEmployeeControllerDeleteEmployee()
        {
            var response = await DeleteEmployeeAsync();
            var jsonContent = JsonConvert.DeserializeObject<DelletedEmployeeModel>(response.Content);
            var actualMessage = jsonContent.message;
            var expectedMessage = ConfigConstants.SuccessMessageDEL;
            Assert.AreEqual(expectedMessage, actualMessage, "User not deleted");
        }

        
    }
}
