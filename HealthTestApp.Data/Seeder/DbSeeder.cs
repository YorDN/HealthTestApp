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
                    new Test { Name = "Ruffier-Dickson", Type = Models.Enumerations.TestType.Physical, EstimatedDuration=10, Description= "Ruffier-Dickson is a test, measuring the user's heart recovery as well as their vessel's hardness", Difficulty = "Easy" },
                    new Test { Name = "Luscher-Color", Type = Models.Enumerations.TestType.Psychological, EstimatedDuration = 1, Description= "The Luscher Color test measures your anxiety and shows you what to do to get better", Difficulty= "Easy" }
                );
            }

            await context.SaveChangesAsync();
        }
    }
}
