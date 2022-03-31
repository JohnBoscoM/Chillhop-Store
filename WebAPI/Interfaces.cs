using System.Threading.Tasks;

namespace ChillhopStore.API
{
    public interface ITokenClaimsService
    {
        Task<string> GetTokenAsync(string userName);
    }
}
