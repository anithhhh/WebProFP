using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Data
{
    public class BakeryContext : IdentityDbContext
    {
        public BakeryContext(DbContextOptions<BakeryContext> options) : base(options) { }

        // Add your DbSet for recipes
        public DbSet<Recipe> Recipes { get; set; }
    }

    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
    }
}
