using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp.Net_Core_CRUD_Operation.Model;

namespace Asp.Net_Core_CRUD_Operation.Data
{
    public class AspNet_Core_CRUD_OperationContext : DbContext
    {
        public AspNet_Core_CRUD_OperationContext (DbContextOptions<AspNet_Core_CRUD_OperationContext> options)
            : base(options)
        {
        }

        public DbSet<Asp.Net_Core_CRUD_Operation.Model.User> User { get; set; } = default!;
    }
}
