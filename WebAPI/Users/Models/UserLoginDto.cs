namespace WebAPI.Users.Models
{
    public class UserLoginDto
    {
        public required string UserName { get; set; }
        public required string PasswordHash { get; set; }
    }
}
