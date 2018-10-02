using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace Planner2Excel.Pages
{
    public class SignOutModel : PageModel
    {
        public AzureAdB2COptions AzureAdB2COptions { get; set; }

        public SignOutModel(IOptions<AzureAdB2COptions> b2cOptions)
        {
             AzureAdB2COptions = b2cOptions.Value;
        }

        public IActionResult OnGet()
        {
            if(User.Identity.IsAuthenticated)
            {         
            var callbackUrl = Url.Action(nameof(SignOut), "Session", values: null, protocol: Request.Scheme);

            return SignOut(new AuthenticationProperties { RedirectUri = callbackUrl },
            CookieAuthenticationDefaults.AuthenticationScheme, OpenIdConnectDefaults.AuthenticationScheme);
            }
            else
            {
                return null;
            }
        }
    }
}