using Microsoft.Identity.Client;

namespace Planner2Excel
{
    public class B2CGraphClient
    {
        private readonly string clientId;
        private readonly string clientSecret;
        private readonly string tenant;
        private readonly string resource = "https://graph.microsoft.com/";
        
        private readonly string authority;

        public B2CGraphClient(string clientId, string clientSecret, string tenant)
        {
            // The client_id, client_secret, and tenant are provided in Program.cs, which pulls the values from App.config
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            this.tenant = tenant;
            authority = $"https://login.microsoftonline.com/{tenant}";
            
        }
    }
}