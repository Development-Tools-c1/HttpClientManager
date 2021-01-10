using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace HttpClientManager.Http.Client.Auth
{
    public class BasicAuth
    {
        public HttpClient Client { get; set; }
        private byte[] AuthToken { get; set; }
        public BasicAuth(string userName, string password, string endPointUrl)
        {
            Client = HttpClientFactory.CreateHttpClient(endPointUrl);
            AuthToken = Encoding.ASCII.GetBytes($"{userName}:{password}");
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(AuthToken));
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));            
        }
        public static BasicAuth CreateBasicAuthClient(string userName, string password, string endPointURL)
        {
            return new BasicAuth(userName, password, endPointURL);
        }
    }
}
