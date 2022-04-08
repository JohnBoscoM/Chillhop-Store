using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;

namespace ChillhopStore.API.Public_API
{
    public class JwtAuthenticationManager : IJwtAuthenticationManager
    {
        private IDictionary<string, string> users = new Dictionary<string, string> { { "user1", "password1" }, { "users2", "password2" } };
        public string Authenticate(string usernamen, string password)
        {
            var tokenHandler = JwtSecurityTokenHandler();
        }
    }
}
