using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Planner2Excel.Pages
{
    [Authorize]
    public class PlannerModel : PageModel
    {
        private const string requestUrl = "https://graph.microsoft.com/v1.0/me/planner/tasks";
        public void OnGet()
        {
        }
    }
}