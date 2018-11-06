using PraiseProvisions.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraiseProvisions.Models.Services
{
    public class UserProfileServices : IUserProfile
    {
        public Task CreateUserProfile(UserProfile profile)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserProfile(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> GetUserProfile(int? ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserProfile>> GetUserProfiles()
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserProfile(UserProfile profile)
        {
            throw new NotImplementedException();
        }
    }
}
