using HealthTestApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HealthTestApp.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions)
            : base(dbContextOptions)
    {

    }
    public DbSet<Test> Tests { get; set; }
    public DbSet<UserTest> UserTests { get; set; }
    public DbSet<TestQuestion> TestQuestions { get; set; }
    public DbSet<TestAnswer> TestAnswers { get; set; }
    public DbSet<TestResult> TestResults { get; set; }
    public DbSet<PhysicalMetric> PhysicalMetrics { get; set; }

}
