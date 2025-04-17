using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthTestApp.Data.DTOs;
using HealthTestApp.Data.Models;

namespace HealthTestApp.Service.TestServices
{
    public interface IHealthTestService
    {
        Task<ResultDto> SaveTestAsync(Guid userId, object testData);
        Task<IEnumerable<UserTest>> GetTestsForUserAsync(Guid userId);
    }
}
