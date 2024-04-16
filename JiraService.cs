using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SimpleJira.Interfaces;

namespace SimpleJira
{
    public class JiraService : IJiraActions, IJiraAuth
    {
        private readonly HttpClient _httpClient;
        private string accessToken { get; set; }
        public JiraService(HttpClient httpClient)
        {

        }
        public Task<bool> CreateNewTicket()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTicket(int ticketId)
        {
            throw new NotImplementedException();
        }

        private Task<string> GetAccessTokenAsync(int clientId, string clientSecret, string redirectUri, string code)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<string>> GetAllProjects()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<JiraProject>> GetProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<JiraTicket>> GetTicketsFromProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTicket(int ticketId)
        {
            throw new NotImplementedException();
        }
    }
}
