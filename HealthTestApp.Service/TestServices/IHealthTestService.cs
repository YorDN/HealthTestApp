using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthTestApp.Data.Models;

namespace HealthTestApp.Service.TestServices
{
    public interface IHealthTestService
    {
        Task SaveTestAsync(string userId, object testData);
        Task<IEnumerable<UserTest>> GetTestsForUserAsync(string userId);
    }
}
