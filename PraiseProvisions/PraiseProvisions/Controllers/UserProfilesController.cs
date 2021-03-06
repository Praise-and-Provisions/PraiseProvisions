﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PraiseProvisions.Models;
using PraiseProvisions.Models.Interfaces;
using System.Linq;
using System;

namespace PraiseProvisions.Controllers
{
    public class UserProfilesController : Controller
    {
        private readonly IUserProfile _profiles;

        public UserProfilesController(IUserProfile context)
        {
            _profiles = context;
        }

        /// <summary>
        /// Gets the UserProfiles
        /// </summary>
        /// <returns>Returns the Index page</returns>
        public async Task<IActionResult> Index()
        {
            return View(await _profiles.GetUserProfiles());
        }

       /// <summary>
       /// Gets a UserProfile
       /// </summary>
       /// <param name="id">User ID</param>
       /// <returns>UserProfile Detail view</returns>
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // create new reference to the existing user profile in the database
            UserProfile profile = await _profiles.GetUserProfile(id);

            if (profile == null)
            {
                return NotFound();
            }

            return View(profile);
        }

        /// <summary>
        /// Creates a User ID
        /// </summary>
        /// <returns>UserProfile Create view</returns>
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserProfiles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID, fullName")] UserProfile profile)
        {
            var returnUser = await _profiles.GetUserProfile(profile.fullName);

            if (returnUser != null)
            {
                return RedirectToAction("UserIndex", "Home", new { userID = returnUser.ID });
            }
            else
            {
                if (ModelState.IsValid)
                {
                    await _profiles.CreateUserProfile(profile);
                    return RedirectToAction("UserIndex", "Home", new { userID = profile.ID });
                }
            }
            return RedirectToAction("UserProfiles", "Create");
        }

        // GET: UserProfiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profile = await _profiles.GetUserProfile(id);
            if (profile == null)
            {
                return NotFound();
            }
            return View(profile);
        }

        // POST: UserProfiles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,fullName")] UserProfile profile)
        {
            if (id != profile.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _profiles.UpdateUserProfile(profile);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserProfileExists(profile.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(profile);
        }

        private bool UserProfileExists(int id)
        {
            return _profiles.GetUserProfile(id) != null;
        }
    }
}
