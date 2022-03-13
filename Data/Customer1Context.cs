#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Customer1.Model;

namespace Customer1.Data
{
    public class Customer1Context : DbContext
    {
        public Customer1Context (DbContextOptions<Customer1Context> options)
            : base(options)
        {
        }

        public DbSet<Customer1.Model.Customer> Customer { get; set; }
    }
}
