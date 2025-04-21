using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HealthTestApp.Data;
using HealthTestApp.Data.DTOs;
using HealthTestApp.Data.Models;

namespace HealthTestApp.Service.TestServices
{
    public class LuscherColorTestService : IHealthTestService
    {
        private ApplicationDbContext _context;
        public LuscherColorTestService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<UserTest>> GetTestsForUserAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultDto> SaveTestAsync(Guid userId, object testData)
        {
            var json = JsonSerializer.Serialize(testData);
            var testLuscher = _context.Tests.FirstOrDefault(t => t.Name == "Luscher-Color");
            if (testLuscher is null)
            {
                return new ResultDto
                {
                    IsValid = false,
                    Message = "The test is not in the database!"
                };
            }
            var test = new UserTest()
            {
                ApplicationUserId = userId,
                TestId = testLuscher.Id,
                TestDataJson = json,
                TestName = testLuscher.Name,
                TakenAt = DateTime.Now

            };
            _context.UserTests.Add(test);
            await _context.SaveChangesAsync();
            return new ResultDto
            {
                IsValid = true
            };
        }
    }
}
