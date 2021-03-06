﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace PraiseProvisions.Models.Interfaces
{
    public interface IUserProfile
    {
        //Create
        Task CreateUserProfile(UserProfile profile);

        //Updating
        Task UpdateUserProfile(UserProfile profile);

        //Reading
        Task<List<UserProfile>> GetUserProfiles(); //gets all profiles
        Task<UserProfile> GetUserProfile(int? ID); //gets a single profile by ID
        Task<UserProfile> GetUserProfile(string fullName); //gets a single profile by name
    }
}
