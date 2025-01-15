using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using WebAPI.Users.Models;

namespace WebAPI.Security
{
    public sealed class TokenProvider(IConfiguration configuration)
    {
        public string CreateToken(User user)
        {
            string secret = configuration["jwt:secret"]!;
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity(
                [
                    new Claim(JwtRegisteredClaimNames.Sub, user.Guid.ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                ]),
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = credentials,
                Issuer = configuration["jwt:issuer"],
                Audience = configuration["jwt:audience"],
            };

            var handler = new JsonWebTokenHandler();
            string token = handler.CreateToken(tokenDescriptor);

            return token;
        }
    }
}
