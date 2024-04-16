namespace SimpleJira.Interfaces
{
    internal interface IJiraAuth
    {
        private string accessToken { get; set; }
        private Task<string> GetAccessTokenAsync(int clientId, string clientSecret, string redirectUri, string code);
    }
}