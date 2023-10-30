using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proj30102023.Models;

namespace Proj30102023.Data
{
    public class Proj30102023Context : DbContext
    {
        public Proj30102023Context (DbContextOptions<Proj30102023Context> options)
            : base(options)
        {
        }

        public DbSet<Proj30102023.Models.Client> Client { get; set; } = default!;
    }
}
