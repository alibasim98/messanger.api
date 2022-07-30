using messanger.core.Data;
using messanger.core.Repoisitory;
using messanger.core.service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace messanger.infra.service
{
    public class JwtService : IJwtService
    {
        private readonly IJwtRepository jwtRepository;
        public JwtService(IJwtRepository _jwtRepository)
        {
            jwtRepository = _jwtRepository;
        }
        public string Auth(logins_api login)
        {
            var result = jwtRepository.Auth(login);
            if (result == null)
            {
                return null;
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]  {
                        new Claim(ClaimTypes.Name, result.username),
                        new Claim(ClaimTypes.Role, result.role_id.ToString()),
                    }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),
                                             SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }

        }
    }
}
