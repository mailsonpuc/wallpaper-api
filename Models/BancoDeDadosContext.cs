using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace wallpaper_api.Models
{
    public class BancoDeDadosContext : DbContext
    {
        public BancoDeDadosContext(DbContextOptions<BancoDeDadosContext> options) : base(options)
        {

        }

        public DbSet<WallpaperItem> WallpaperItems { get; set; } = null;
        
    }
}