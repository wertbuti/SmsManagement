using Newtonsoft.Json;
using SmsManagement.SheredKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SmsManagement.SheredKernel
{
    public class ApiCaller : IApiCaller
    {
        private readonly string _url;

        public ApiCaller(string url)
        {
            _url = url;
        }
        public async Task PostAsync(string requestUrl,object obj)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(_url);
            var jSonData = JsonConvert.SerializeObject(obj);
            var content = new StringContent(jSonData, Encoding.UTF8, "application/json");

             client.PostAsync(requestUrl, content);
        }
    }
}
