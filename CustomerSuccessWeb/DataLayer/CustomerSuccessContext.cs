using CustomerSuccessWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSuccessWeb.DataLayer
{
    public class CustomerSuccessContext: DbContext
    {
        public CustomerSuccessContext(DbContextOptions<CustomerSuccessContext> options)
            : base (options)
        {
            this.Database.Migrate();
        }

        public DbSet<Client> Clients { get; set; }
    }
}
