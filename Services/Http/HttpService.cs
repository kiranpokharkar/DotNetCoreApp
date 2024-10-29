
using System.Text.Json;

namespace Demo.Services.Http
{
    public class HttpService : IHttpService
    {

        private readonly HttpClient _httpClient;

        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<HttpRequestMessage> CreateHttpResponseMessage<T>(string url, HttpMethod method, T body = default)
        {
            var request = new HttpRequestMessage(method, url);

            if (body == null)
            {
                request.Content = new StringContent(JsonSerializer.Serialize(body));
            }

            return request;
        }

        private async Task<T> SendAsync<T>(HttpRequestMessage request)
        {
            var response = await _httpClient.SendAsync(request);

           //TODO: Error Handle

            string responseString = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<T>(responseString);
        }

        public async Task<T> GetAsync<T>(string url)
        {
            var request = await CreateHttpResponseMessage<T>(url, HttpMethod.Get);

            return await SendAsync<T>(request);

        }

        public async Task<T> PostAsync<T, T1>(string url, T1 data)
        {
            var request = await CreateHttpResponseMessage(url, HttpMethod.Post, data);

            return await SendAsync<T>(request);
        }
    }
}
