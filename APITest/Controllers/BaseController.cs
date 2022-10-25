using APITest.Constants;
using APITest.Managers;
using APITest.Models;
using FluentAssertions.Equivalency;
using NUnit.Framework;
using RestSharp;
using RestSharp.Validation;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APITest.Controllers
{
    public class BaseController : ConfigManager
    {
        protected string BaseUrl => Config[ConfigConstants.BaseUrl];
        protected RestClient RestClient => new RestClient(this.BaseUrl);

        protected async Task<IRestResponse> GetAsync(string resource)
        {
            var request = new RestRequest(resource, Method.GET);
            return await this.RestClient.ExecuteAsync<IRestResponse>(request, Method.GET);
        }

        protected async Task<IRestResponse> PostAsync(string resource, NewEmployeeDataModel model)
        {
            var request = new RestRequest(resource, Method.POST);
            request.AddJsonBody(model);
            return await this.RestClient.ExecuteAsync<IRestResponse>(request, Method.POST);
        }

        protected async Task<IRestResponse> DeleteAsync(string resource)
        {
            var request = new RestRequest(resource, Method.DELETE);
            return await this.RestClient.ExecuteAsync<IRestResponse>(request, Method.DELETE);
        }   

        protected async Task<IRestResponse> PutAsync(string resource, NewEmployeeDataModel model)
        {
            var request = new RestRequest(resource, Method.PUT);
            request.AddJsonBody(model);
            return await this.RestClient.ExecuteAsync<IRestResponse>(request, Method.PUT);
        }

    }
}
