using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace finalProject.Models
{
    public class Token
    {
        readonly IConfiguration configuration;
        public Token(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public string GenerateToken(int Id, string email)
        {
            try
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:secretKey"]));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                    issuer: configuration["JWT:Issuer"],
                    audience: configuration["JWT:Audience"],
                    claims: new List<Claim>() {
                   new Claim(ClaimTypes.NameIdentifier, Id.ToString()),
                   new Claim(ClaimTypes.Email, email),
                   new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                   new Claim(JwtRegisteredClaimNames.Exp, DateTimeOffset.UtcNow.AddHours(10).ToUnixTimeSeconds().ToString())
                    },
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return tokenString;
            }catch(Exception ex)
            {
                return(ex.Message);
            }
        }
    }
}
