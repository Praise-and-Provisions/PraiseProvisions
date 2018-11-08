using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PraiseProvisions.Data;
using PraiseProvisions.Models;
using PraiseProvisions.Models.Interfaces;

namespace PraiseProvisions.Controllers
{
    public class UserProfilesController : Controller
    {
        private readonly IUserProfile _profiles;

        public UserProfilesController(IUserProfile context)
        {
            _profiles = context;
        }

        // GET: UserProfiles
     
        public async Task<IActionResult> Index()
        {
            return View(await _profiles.GetUserProfiles());
        }

        // GET: UserProfiles/Details/5
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

        // GET: UserProfiles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserProfiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,fullName")] UserProfile profile)
        {
            if (ModelState.IsValid)
            {
                // Create the user profile through dependency service
                await _profiles.CreateUserProfile(profile);

                return RedirectToAction(nameof(Index));
            }
            return View(profile);
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
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: UserProfiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            UserProfile profile = await _profiles.GetUserProfile(id);

            if (profile == null)
            {
                return NotFound();
            }

            return View(profile);
        }

        // POST: UserProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _profiles.DeleteUserProfile(id);
            return RedirectToAction(nameof(Index));
        }

        private bool UserProfileExists(int id)
        {
            return _profiles.GetUserProfile(id) != null;
        }
    }
}
