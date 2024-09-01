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
    public class IndexModel : PageModel
    {
        private readonly Asp.Net_Core_CRUD_Operation.Data.AspNet_Core_CRUD_OperationContext _context;

        public IndexModel(Asp.Net_Core_CRUD_Operation.Data.AspNet_Core_CRUD_OperationContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
