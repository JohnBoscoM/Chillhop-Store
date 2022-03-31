using System;

namespace ChillhopStore.API.Public_API
{
    public class AuthenticationResponse : BaseResponse
    {
        public AuthenticationResponse(Guid correlationId) : base(correlationId)
        {
        }

        public AuthenticationResponse()
        {
        }
        public bool Result { get; set; } = false;
        public string Token { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public bool IsLockedOut { get; set; } = false;
        public bool IsNotAllowed { get; set; } = false;
        public bool RequiresTwoFactor { get; set; } = false;
    }
}
