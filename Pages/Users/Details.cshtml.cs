using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Asp.Net_Core_CRUD_Operation.Data;
using Asp.Net_Core_CRUD_Operation.Model;

namespace Asp.Net_Core_CRUD_Operation.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly Asp.Net_Core_CRUD_Operation.Data.AspNet_Core_CRUD_OperationContext _context;

        public DetailsModel(Asp.Net_Core_CRUD_Operation.Data.AspNet_Core_CRUD_OperationContext context)
        {
            _context = context;
        }

        public User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                User = user;
            }
            return Page();
        }
    }
}
