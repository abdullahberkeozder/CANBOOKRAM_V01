using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CANBOOKRAM_V01.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace CANBOOKRAM_V01.Pages.post
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly CANBOOKRAM_V01.Models.CANBOOKRAM_V01Context _context;
        private readonly UserManager<IdentityUser> _userManager;

        public IndexModel(CANBOOKRAM_V01.Models.CANBOOKRAM_V01Context context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IList<UserPost> UserPost { get; set; } = default!;

        public async Task OnGetAsync()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            UserPost = await _context.UserPosts.Where(u => u.UserId == userId).ToListAsync();

        }
    }
}
