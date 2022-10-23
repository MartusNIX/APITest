using APITest.Constants;
using APITest.Managers;
using RestSharp;
using System.Threading.Tasks;

namespace APITest.Controllers
{
    public class BaseController : ConfigManager
    {
        protected string BaseUrl => Config[ConfigConstants.BaseUrl];
        protected RestClient RestClient => new RestClient(this.BaseUrl);

        protected async Task<object> GetAsync(string resource)
        {
            var request = new RestRequest(resource, Method.GET);
            return await this.RestClient.GetAsync<object>(request);
        }

        protected async Task<object> PostAsync(string resource)
        {
            var request = new RestRequest(resource, Method.POST);
            return await this.RestClient.GetAsync<object>(request);
        }

        protected async Task<object> DeleteAsync(string resource)
        {
            var request = new RestRequest(resource, Method.DELETE);
            return await this.RestClient.GetAsync<object>(request);
        }   

        protected async Task<object> PutAsync(string resource)
        {
            var request = new RestRequest(resource, Method.PUT);
            return await this.RestClient.GetAsync<object>(request);
        }

    }
}
