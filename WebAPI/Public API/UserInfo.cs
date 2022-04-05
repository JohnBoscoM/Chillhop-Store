using System.Collections.Generic;

namespace ChillhopStore.API.Public_API
{
    public class UserInfo
    {
        public static readonly UserInfo Anonymous = new UserInfo();
        public bool IsAuthenticated { get; set; }
        public string NameClaimType { get; set; }
        public string RoleClaimType { get; set; }
        public IEnumerable<ClaimValue> Claims { get; set; }
        public string Token { get; set; }
    }
}
