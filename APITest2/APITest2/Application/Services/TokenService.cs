using APITest2.Domain.Model.EmployeeAggregate;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace APITest2.Application.Services
{
    public class TokenService
    {
        public static object GenerateToken(Employee employee)
        {
            byte[] key = Encoding.ASCII.GetBytes(Key.Secret);
            SecurityTokenDescriptor tokenConfig = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                      new Claim("employeeId", employee.Id.ToString()),
                }),
                Expires = DateTime.UtcNow.AddHours(3),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken token = tokenHandler.CreateToken(tokenConfig);
            string tokenString = tokenHandler.WriteToken(token);

            return new
            {
                token = tokenString
            };
        }
    }
}
