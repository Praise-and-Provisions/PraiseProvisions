﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PraiseProvisions.Data;
using PraiseProvisions.Models;

namespace PraiseProvisions.Controllers
{
    public class UserFavoritesController : Controller
    {
        private readonly PraiseProvisionDbContext _context;

        public UserFavoritesController(PraiseProvisionDbContext context)
        {
            _context = context;
        }

        // GET: UserFavorites
        /// <summary>
        /// Gets user favorites
        /// </summary>
        /// <param name="id">user profile id</param>
        /// <returns>User favorites Index view page</returns>
        public async Task<IActionResult> Index(int id)
        {
            var favorite = await _context.UserFavorites
                .Include(p => p.UserProfile)
                .Include(r => r.Restaurant)
                .Where(f => f.UserProfileID == id)
                .Select(f =>
                   new Restaurant
                   {
                       ID = f.Restaurant.ID,
                       Name = f.Restaurant.Name,
                       Address = f.Restaurant.Address,
                       Description = f.Restaurant.Description
                   }
                ).ToListAsync();
            return View(favorite);
        }
    }
}
