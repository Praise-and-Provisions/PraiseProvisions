using Microsoft.EntityFrameworkCore;
using PraiseProvisions.Data;
using PraiseProvisions.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraiseProvisions.Models.Services
{
    public class UserProfileServices : IUserProfile
    {
        private PraiseProvisionDbContext _context;

        public UserProfileServices(PraiseProvisionDbContext context)
        {
            _context = context;
        }

        public async Task CreateUserProfile(UserProfile profile)
        {
            _context.UserProfiles.Add(profile);
            await _context.SaveChangesAsync();
        }

        public async Task<UserProfile> GetUserProfile(int? id)
        {
            return await _context.UserProfiles.FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<UserProfile> GetUserProfile(string fullName)
        {
            return await _context.UserProfiles.FirstOrDefaultAsync(x => x.fullName == fullName);
        }

        public async Task<List<UserProfile>> GetUserProfiles()
        {
            return await _context.UserProfiles.ToListAsync();
        }

        public async Task UpdateUserProfile(UserProfile profile)
        {
            _context.UserProfiles.Update(profile);
            await _context.SaveChangesAsync();
        }
    }
}
