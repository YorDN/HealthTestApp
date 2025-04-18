
using HealthTestApp.Data;
using HealthTestApp.Data.DTOs;
using HealthTestApp.Data.Models;
using HealthTestApp.Data.Models.Enumerations;
using Microsoft.EntityFrameworkCore;

namespace HealthTestApp.Service.TestServices
{
    public class TestService
    {
        private ApplicationDbContext _dbContext;
        public TestService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ResultDto> AddTestAsync(AddTestDto testDto)
        {
            List<Test> tests = await _dbContext.Tests.ToListAsync();
            ResultDto result = new ResultDto();
            if (tests.Any(t => t.Name == testDto.Name))
            {
                result.IsValid = false;
                result.Message = "A test with this name already exists in the Data base!";
                return  result;
            }
            if(!Enum.TryParse<TestType>(testDto.Type, out TestType type))
            {
                result.IsValid = false;
                result.Message = "Invalid test type!";
                return result;
            }
            Test test = new Test()
            {
                Name = testDto.Name,
                Description = testDto.Description,
                Type = type,
                CreatedAt = DateTime.Now
            };
            await _dbContext.Tests.AddAsync(test);
            await _dbContext.SaveChangesAsync();
            result.IsValid = true;
            result.Message = "Test added successfully!";
            return result;
        }
        public async Task<List<Test>> GetAllTests()
        {
            return await _dbContext.Tests.ToListAsync();
        }
        public async Task<List<Test>> GetNTests(int n)
        {
            return await _dbContext.Tests.Take(n).ToListAsync();
        }
    }
}
