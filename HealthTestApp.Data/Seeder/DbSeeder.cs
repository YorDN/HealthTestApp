using HealthTestApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTestApp.Data.Seeder
{
    public static class DbSeeder
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            await context.Database.MigrateAsync();

            // Seed Users (example)
            if (!context.Tests.Any())
            {
                context.Tests.AddRange(
                    new Test { Name = "Ruffier-Dickson", Type = Models.Enumerations.TestType.Physical, EstimatedDuration=10},
                    new Test { Name = "Luffier-Color", Type = Models.Enumerations.TestType.Psychological, EstimatedDuration = 1 }
                );
            }

            await context.SaveChangesAsync();
        }
    }
}
