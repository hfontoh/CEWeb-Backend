using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEWeb.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                 new User { userId = 1, firstName = "Dan" },
                 new User { userId = 2, firstName = "Zack" },
                 new User { userId = 3, firstName = "Zeph" });
        }
    }
}
