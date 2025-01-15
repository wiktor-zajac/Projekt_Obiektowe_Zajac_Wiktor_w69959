namespace WebAPI.Users.Models
{
    public class User
    {
        public Guid Guid { get; set; } = Guid.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
    }
}
