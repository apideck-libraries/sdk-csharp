using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;

namespace ApideckUnifySdk.Hooks
{

    using ApideckUnifySdk.Utils;
    using ApideckUnifySdk.Models.Components;

    public class AuthHook : IBeforeRequestHook
    {
        public async Task<HttpRequestMessage> BeforeRequestAsync(BeforeRequestContext hookCtx, HttpRequestMessage request)
        {
            // Get the API key from the Authorization header
            if (request.Headers.TryGetValues("Authorization", out var authValues))
            {
                var apiKey = authValues.FirstOrDefault();
                if (!string.IsNullOrEmpty(apiKey))
                {
                    // Remove the existing Authorization header
                    request.Headers.Remove("Authorization");
                    // Add the Bearer token
                    request.Headers.Add("Authorization", $"Bearer {apiKey}");
                }
            }

            return request;
        }
    }
}