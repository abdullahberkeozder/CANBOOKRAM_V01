﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CANBOOKRAM_V01.Models;
using Microsoft.AspNetCore.Authorization;

namespace CANBOOKRAM_V01.Pages.post
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly CANBOOKRAM_V01.Models.CANBOOKRAM_V01Context _context;

        public DetailsModel(CANBOOKRAM_V01.Models.CANBOOKRAM_V01Context context)
        {
            _context = context;
        }

        public UserPost UserPost { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.UserPosts == null)
            {
                return NotFound();
            }

            var userpost = await _context.UserPosts.FirstOrDefaultAsync(m => m.Id == id);
            if (userpost == null)
            {
                return NotFound();
            }
            else
            {
                UserPost = userpost;
            }
            return Page();
        }
    }
}
