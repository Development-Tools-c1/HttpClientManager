using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HttpClientManager.Http.Client
{
    public class HttpClientFactory
    {
        public HttpClient HttpClient { get; set; }
        public HttpClientFactory()
        {
            HttpClient = new HttpClient();
        }
        public static HttpClient CreateHttpClient()
        => new HttpClientFactory().HttpClient;
        public static HttpClient CreateHttpClient(string endPointURL)
        {
            var httpClient = new HttpClientFactory().HttpClient;
            httpClient.BaseAddress = new Uri(endPointURL);
            return httpClient;
        }
    }

}
