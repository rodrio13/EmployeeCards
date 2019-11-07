using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Me2You.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Omar",
                    Department = Dept.IT,
                    Email = "omarrodriguezz725@gmail.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Rickia",
                    Department = Dept.HR,
                    Email = "culmer97@gmail.com"
                });
        }
    }
}
