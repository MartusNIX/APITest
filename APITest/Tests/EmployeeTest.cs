using APITest.Constants;
using APITest.Controllers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnit.Framework.Internal.Commands;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace APITest.Tests
{
    [TestFixture]
    public class EmployeeTest : EmployeeController
    {
        [Test]
        public async Task CheckThatEmployeeControllerReturnsResponse()
        {
            var response = await this.GetEmployeeAsync();
            response.Should().NotBeNull("Response is null");
        }
    }
}
