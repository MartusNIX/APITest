using APITest.Models;
using RestSharp;
using System.Threading.Tasks;

namespace APITest.Controllers
{
    public class EmployeeController : BaseController
    {
        private const string GetEmployeeUrl = "/employees";
        private const string GetEmployeeByIdUrl = "/employee/1";
        private const string PostEmployeeUrl = "/create";
        private const string DeleteEmployeeUrl = "/delete/{0}";
        private const string PutEmployeeUrl = "/update/{0}";
        private const string GetNonExistentEmployeeByIdUrl = "/employee/{0+24}";
        private const string DeleteNonExistentEmployeeByIdUrl = "/delete/{0+24}";
        private const string PutNonExistentEmployeeByIdUrl = "/update/{0+24}";


        protected async Task<IRestResponse> GetEmployeeAsync()
        {
            var resource = string.Join(this.BaseUrl, GetEmployeeUrl);
            return await this.GetAsync(resource);
        }

        protected async Task<IRestResponse> GetEmployeeByIdAsync()
        {
            var resource = string.Join(this.BaseUrl,GetEmployeeByIdUrl);
            return await this.GetAsync(resource);
        }

        protected async Task<IRestResponse> PostEmployeeAsync(CreateEmployeeDataModel model)
        {
            var resourse = string.Join(this.BaseUrl, PostEmployeeUrl);
            return await this.PostAsync(resourse, model);
        }
    }
}
