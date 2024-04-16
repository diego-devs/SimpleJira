using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace SimpleJira
{
    internal class JiraAuth
    {
        private readonly HttpClient _httpClient;
        public JiraAuth(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetAccessToken(int clientId, string clientSecret, string redirectUri, string code)
        {
            try
            {
                var requestBody = new
                {
                    grant_type = "authorization_code",
                    client_id = clientId,
                    client_secret = clientSecret, 
                    redirect_uri = redirectUri,
                    code = code
                };
                var requestContent = new StringContent(JsonSerializer.Serialize(requestBody));
                requestContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                // make the http request
                var response = await _httpClient.PostAsync("http://diego-devs.atlassian.net/rest/auth/1/session", requestContent);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var tokenResponse = JsonSerializer.Deserialize<TokenResponse>(responseContent);
                    return tokenResponse?.AccessToken;
                }
                else
                {
                    throw new Exception($"Failed to retrieve access token. Status Code: {response.StatusCode}");
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error retrieving access token", e);
            }
        }
    }

}
