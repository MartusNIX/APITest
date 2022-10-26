using APITest.Constants;
using APITest.Controllers;
using APITest.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;


namespace APITest.Tests
{
    [TestFixture]
    public class EmployeeTest : EmployeeController
    {
        [Test]
        public async Task CheckThatEmployeeControllerReturnAllEmployees()
        {
            var response = await this.GetEmployeesAsync();
            var jsonContent = JsonConvert.DeserializeObject<AllEmployeesModel>(response.Content);
            var actualStatus = jsonContent.status;
            var expectedStatus = ConfigConstants.ExpectedStatus;

            Assert.AreEqual(expectedStatus, actualStatus, "All Employees not found");
        }

        [Test]
        public async Task CheckThatEmployeeControllerReturnsResponseById()
        {
            var response = await this.GetOneEmployeeAsync("10");
            var jsonContent = JsonConvert.DeserializeObject<SingleEmployeeModel>(response.Content);
            var actualId = jsonContent.data.id;
            var expectedId = "10";

            Assert.AreEqual(expectedId, actualId, "User by ID not found");
        }

        [Test]
        public async Task CheckThatEmployeeControllerCreateNewEmployee()
        {
            var model = new NewEmployeeDataModel
            {
                name = "Krol",
                salary = "5000",
                age = "29"
            };
            var sentResponse = await this.PostEmployeeAsync(model);
            var jsonContent = JsonConvert.DeserializeObject<NewEmployeeDataModel>(sentResponse.Content);
            var actualMessage = jsonContent.message;
            var expectedMessage = ConfigConstants.SuccessMessagePOST;

            Assert.AreEqual(expectedMessage, actualMessage, "User not created");
        }        

        [Test]
        public async Task CheckThatEmployeeControllerUpdateEmployee()
        {
            var model = new NewEmployeeDataModel
            {
                name = "Ichigo",
                salary = "3000",
                age = "2022"
            };
            var sentResponse = await this.PutEmployeeAsync("2", model);
            var jsonContent = JsonConvert.DeserializeObject<SingleEmployeeModel>(sentResponse.Content);
            var actualMessage = jsonContent.message;
            var expectedMessage = ConfigConstants.SuccessMessagePUT;

            Assert.AreEqual(expectedMessage, actualMessage, "User not updeted");
        }

        [Test]
        public async Task CheckThatEmployeeControllerDeleteEmployee()
        {
            var response = await this.DeleteEmployeeAsync("3");
            var jsonContent = JsonConvert.DeserializeObject<DelletedEmployeeModel>(response.Content);
            var actualMessage = jsonContent.message;
            var expectedMessage = ConfigConstants.SuccessMessageDEL;

            Assert.AreEqual(expectedMessage, actualMessage, "User not deleted");
        }

        [Test]
        public async Task CheckEmployeeExists()
        {
            var response = await this.GetOneEmployeeAsync("1");
            var jsonContent = JsonConvert.DeserializeObject<SingleEmployeeModel>(response.Content);
            var isEmployeeExist = jsonContent.data != null;

            Assert.IsTrue(isEmployeeExist, "User data is null");
        }

        [Test]
        public async Task CheckEmployeeDoesNotExist()
        {
            var response = await this.GetOneEmployeeAsync("100");
            var jsonContent = JsonConvert.DeserializeObject<SingleEmployeeModel>(response.Content);
            var dataIsNull = jsonContent.data == null;

            Assert.IsTrue(dataIsNull, "User data is not null");
        }
    }
}
