namespace ChillhopStore.API.Public_API
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string usernamen, string password);
    }
}
