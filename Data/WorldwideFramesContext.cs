using Microsoft.EntityFrameworkCore;
using WorldwideFrames.Models;

namespace WorldwideFrames.Data
{
    public class WorldwideFramesContext : DbContext
    {
        public WorldwideFramesContext(DbContextOptions<WorldwideFramesContext> options)
            : base(options)
        {
        }

        public DbSet<Frame> Frame { get; set; }
    }
}