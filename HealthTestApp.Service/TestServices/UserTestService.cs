using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthTestApp.Data;
using HealthTestApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthTestApp.Service.TestServices
{
    public class UserTestService
    {
        private ApplicationDbContext _dbContext;
        public UserTestService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<UserTest>> LoadTestsForUser(Guid userId)
        {
            return await _dbContext.UserTests
                                  .Where(t => t.ApplicationUserId == userId)
                                  .Include(t => t.Test)
                                  .ToListAsync();
        }
        public async Task<UserTest?> GetUserTestByIdAsync(Guid testId)
        {
            return await _dbContext.UserTests.FirstOrDefaultAsync(x => x.Id == testId);
        }
    }
}
