using RestSharp;
using System.Threading.Tasks;

namespace APITest.Controllers
{
    public class EmployeeController : BaseController
    {
        private const string GetEmployeeUrl = "/employees";
        private const string GetEmployeeByIdUrl = "/employees/1";
        private const string PostEmployeeUrl = "/create";
        private const string DeleteEmployeeUrl = "/delete/{0}";
        private const string PutEmployeeUrl = "/update/{0}";
        private const string GetNonExistentEmployeeByIdUrl = "/employees/{0+24}";
        private const string DeleteNonExistentEmployeeByIdUrl = "/delete/{0+24}";
        private const string PutNonExistentEmployeeByIdUrl = "/update/{0+24}";


        protected async Task<object> GetEmployeeAsync()
        {
            var resource = string.Join(this.BaseUrl, GetEmployeeUrl);
            return await this.GetAsync(resource);
        }

        protected async Task<object> GetEmployeeByIdAsync(/*int employeeId*/)
        {
            var resource = string.Join(this.BaseUrl, string.Format(GetEmployeeByIdUrl/*, employeeId*/));
            return await this.GetAsync(resource);
        }

/*        protected async Task<object> PostEmployeeUrlAsync()
        {
            var resourse = string.Join(this.BaseUrl, string.Format(PostEmployeeUrl);
        }*/
    }
}
