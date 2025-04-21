using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthTestApp.Data;

namespace HealthTestApp.Service.TestServices
{
    public class UserTestService
    {
        private ApplicationDbContext _dbContext;
        public UserTestService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
