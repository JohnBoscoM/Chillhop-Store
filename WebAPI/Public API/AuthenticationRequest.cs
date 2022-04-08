using Chillhop_Store.Models.Models;
using ChillhopStore.API.Identity;

namespace ChillhopStore.API.Public_API
{
    public class AuthenticationRequest: BaseRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
