namespace DependencyInjection_Test
{
    internal class User
    {
        private INotiflicationService _notiflicationService;
        public string Username { get; private set; }
        public User(string username, INotiflicationService notiflicationService)
        {
            Username = username;
            _notiflicationService = notiflicationService;
        }

        public void ChangeUsername(string newUsername)
        {
            Username = newUsername;
            _notiflicationService.NotifyUsernameChanged(this);
        }
    }
}
