using ChillhopStore.API.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace ChillhopStore.API.Public_API
{
    public class Authenticate
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ITokenClaimsService _tokenClaimsService;

        public Authenticate(SignInManager<ApplicationUser> signInManager, ITokenClaimsService tokenClaimsService)
        {
            _signInManager = signInManager;
            _tokenClaimsService = tokenClaimsService;
        }
    
        public override async Task<ActionResult<AuthenticationResponse>> HandleAsync(AuthenticationRequest authenticationRequest, CancellationToken cancellationToken)
        {
            var response = new AuthenticationResponse(authenticationRequest.CorrelationId());

            var result = await _signInManager.PasswordSignInAsync(authenticationRequest.Username,authenticationRequest.Password, false,true);
            response.Result = result.Succeeded;
            response.IsLockedOut = result.IsLockedOut;
            response.IsNotAllowed = result.IsNotAllowed;
            response.RequiresTwoFactor = result.RequiresTwoFactor;
            response.Username = authenticationRequest.Username;

            if (result.Succeeded)
            {
                response.Token = await _tokenClaimsService.GetTokenAsync(authenticationRequest.Username);
            }
            return response;
        }
    }
}
