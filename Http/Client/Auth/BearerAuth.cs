using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace HttpClientManager.Http.Client.Auth
{
    public class BearerAuth
    {
        public HttpClient Client { get; set; }
        public BearerAuth(string endPointUrl, string authToken)
        {
            Client = HttpClientFactory.CreateHttpClient(endPointUrl);
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static BearerAuth CreateBasicAuthClient(string endPointUrl, string authToken)
        {
            return new BearerAuth(endPointUrl, authToken);
        }
    }
}
