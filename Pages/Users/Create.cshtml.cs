using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Asp.Net_Core_CRUD_Operation.Data;
using Asp.Net_Core_CRUD_Operation.Model;

namespace Asp.Net_Core_CRUD_Operation.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly Asp.Net_Core_CRUD_Operation.Data.AspNet_Core_CRUD_OperationContext _context;

        public CreateModel(Asp.Net_Core_CRUD_Operation.Data.AspNet_Core_CRUD_OperationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
