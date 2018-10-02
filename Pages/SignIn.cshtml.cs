using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Planner2Excel
{
    public class SignInModel : PageModel
    {
        public ActionResult OnGet()
        {
            if (!User.Identity.IsAuthenticated)
            {
                var redirectUrl = Url.Page("/Index");
                return Challenge(
                    new AuthenticationProperties { RedirectUri = redirectUrl }, OpenIdConnectDefaults.AuthenticationScheme);
            }
            else
            {
                Redirect("/Index");
                return null;
            }
        }
    }
}