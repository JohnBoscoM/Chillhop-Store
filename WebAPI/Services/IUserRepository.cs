using Chillhop_Store.Models.Models;
using ChillhopStore.API.Public_API;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChillhopStore.API.Services
{

    public interface IUserRepository 
    {
        public bool UserAuthentication(AuthenticationRequest request); 
    }
    
}
