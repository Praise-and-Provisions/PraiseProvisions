using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraiseProvisions.Models.Interfaces
{
    interface IUserProfile
    {
        //Create
        Task CreateUserProfile(UserProfile profile);

        //Updating
        Task UpdateUserProfile(UserProfile profile);

        //Deleting
        Task DeleteUserProfile(int ID);

        //Reading
        Task<List<UserProfile>> GetUserProfiles(); //gets all profiles
        Task<UserProfile> GetUserProfile(int? ID); //gets a single profile
    }
}
