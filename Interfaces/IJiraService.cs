namespace SimpleJira.Interfaces
{
    public interface IJiraService
    {
        public Task<ICollection<string>> GetAllProjects();
        public Task<ICollection<JiraProject>> GetProject(int projectId);
        public Task<ICollection<JiraTicket>> GetTicketsFromProject(int projectId);
        public Task<bool> CreateNewTicket(); // if created correctly
        public Task<bool> DeleteTicket(int ticketId);
        public Task<bool> UpdateTicket(int ticketId);

    }
}