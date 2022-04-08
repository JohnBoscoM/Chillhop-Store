using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using WebAPI.ConfigObjects;

namespace WebAPI.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddAuthenticationWithAuth0(this IServiceCollection services, Auth0Config auth0Config)
        {
            var accesstoken = "";
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme; ;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options => {
                    options.Authority = auth0Config.Authority;
                    options.Audience = auth0Config.Audience;
                    options.RequireHttpsMetadata= false;

                    options.Events = new JwtBearerEvents()
                    {
                        OnTokenValidated = context =>
                        {
                            if (!(context.SecurityToken is JwtSecurityToken token)) return Task.CompletedTask;
                            if (context.Principal?.Identity is ClaimsIdentity identity)
                            {
                                identity.AddClaim(new Claim("access_token", token.RawData));
                                accesstoken = token.RawData;
                            }

                            return Task.CompletedTask;
                        }
                    };

                });

        }

        public static void AddRoleBasedAuthorizationWithRoles(this IServiceCollection services,
          Dictionary<string, List<string>> rolePolicies)
        {
            services.AddAuthorization(options =>
            {
                foreach (var rolePolicy in rolePolicies)
                {
                    options.AddPolicy(rolePolicy.Key, policy => policy.RequireClaim(ClaimTypes.Role, rolePolicy.Value));
                }
            });
        }

    }
}
