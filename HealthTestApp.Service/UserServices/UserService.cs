using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthTestApp.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace HealthTestApp.Service.UserServices
{
    public class UserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<string?> GetProfilePictureUrlAsync()
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);
            return user?.ProfilePicture;
        }
        public async Task<ApplicationUser?> GetCurrentUserAsync()
        {
            var context = _httpContextAccessor.HttpContext;
            var principal = context?.User;

            if (principal == null || !principal.Identity?.IsAuthenticated == true)
                return null;

            var user = await _userManager.GetUserAsync(principal);

            return user;
        }


    }
}
