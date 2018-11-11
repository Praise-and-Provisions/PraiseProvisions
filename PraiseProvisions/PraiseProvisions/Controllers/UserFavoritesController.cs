using System;
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
        public async Task<IActionResult> Index(int id)
        {
            var test = await _context.UserFavorites
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
            return View(test);
        }

        // GET: UserFavorites/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userFavorite = await _context.UserFavorites
                .Include(u => u.Restaurant)
                .Include(u => u.UserProfile)
                .FirstOrDefaultAsync(m => m.RestaurantID == id);
            if (userFavorite == null)
            {
                return NotFound();
            }

            return View(userFavorite);
        }

        // GET: UserFavorites/Create
        public IActionResult Create()
        {
            ViewData["RestaurantID"] = new SelectList(_context.Restaurants, "ID", "ID");
            ViewData["UserProfileID"] = new SelectList(_context.UserProfiles, "ID", "ID");
            return View();
        }

        // POST: UserFavorites/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserProfileID,RestaurantID")] UserFavorite userFavorite)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userFavorite);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RestaurantID"] = new SelectList(_context.Restaurants, "ID", "ID", userFavorite.RestaurantID);
            ViewData["UserProfileID"] = new SelectList(_context.UserProfiles, "ID", "ID", userFavorite.UserProfileID);
            return View(userFavorite);
        }

        // GET: UserFavorites/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userFavorite = await _context.UserFavorites.FindAsync(id);
            if (userFavorite == null)
            {
                return NotFound();
            }
            ViewData["RestaurantID"] = new SelectList(_context.Restaurants, "ID", "ID", userFavorite.RestaurantID);
            ViewData["UserProfileID"] = new SelectList(_context.UserProfiles, "ID", "ID", userFavorite.UserProfileID);
            return View(userFavorite);
        }

        // POST: UserFavorites/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserProfileID,RestaurantID")] UserFavorite userFavorite)
        {
            if (id != userFavorite.RestaurantID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userFavorite);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserFavoriteExists(userFavorite.RestaurantID))
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
            ViewData["RestaurantID"] = new SelectList(_context.Restaurants, "ID", "ID", userFavorite.RestaurantID);
            ViewData["UserProfileID"] = new SelectList(_context.UserProfiles, "ID", "ID", userFavorite.UserProfileID);
            return View(userFavorite);
        }

        private bool UserFavoriteExists(int id)
        {
            return _context.UserFavorites.Any(e => e.RestaurantID == id);
        }
    }
}
