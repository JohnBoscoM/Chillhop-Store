using Chillhop_Store.Models.Models;

namespace ChillhopStore.API.Public_API
{
    public class AuthenticationRequest: BaseRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
