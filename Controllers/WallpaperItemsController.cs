using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wallpaper_api.Models;

namespace wallpaper_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WallpaperItemsController : ControllerBase
    {
        private readonly BancoDeDadosContext _context;

        public WallpaperItemsController(BancoDeDadosContext context)
        {
            _context = context;
        }

        // GET: api/WallpaperItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WallpaperItem>>> GetWallpaperItems()
        {
            return await _context.WallpaperItems.ToListAsync();
        }

        // GET: api/WallpaperItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WallpaperItem>> GetWallpaperItem(long id)
        {
            var wallpaperItem = await _context.WallpaperItems.FindAsync(id);

            if (wallpaperItem == null)
            {
                return NotFound();
            }

            return wallpaperItem;
        }

        // PUT: api/WallpaperItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWallpaperItem(long id, WallpaperItem wallpaperItem)
        {
            if (id != wallpaperItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(wallpaperItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WallpaperItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/WallpaperItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WallpaperItem>> PostWallpaperItem(WallpaperItem wallpaperItem)
        {
            _context.WallpaperItems.Add(wallpaperItem);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetWallpaperItem", new { id = wallpaperItem.Id }, wallpaperItem);
               return CreatedAtAction(nameof(GetWallpaperItem), new { id = wallpaperItem.Id  }, wallpaperItem);
        }

        // DELETE: api/WallpaperItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWallpaperItem(long id)
        {
            var wallpaperItem = await _context.WallpaperItems.FindAsync(id);
            if (wallpaperItem == null)
            {
                return NotFound();
            }

            _context.WallpaperItems.Remove(wallpaperItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WallpaperItemExists(long id)
        {
            return _context.WallpaperItems.Any(e => e.Id == id);
        }
    }
}
