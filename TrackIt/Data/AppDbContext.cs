using Microsoft.EntityFrameworkCore;
using TrackIt.Models;
using TrackIt.Components;

namespace TrackIt.Data
{
    /// <summary>
    /// Represents the application's database context, used to interact with the underlying database.
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the AppDbContext class with the specified options.
        /// </summary>
        /// <param name="options">The options to be used for configuring DbContext</param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the collection of products in the database.
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the collection of users in the database (if applicable).
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Configures the model and relationships for the entities in the database.
        /// </summary>
        /// <param name="modelBuilder">The model builder used to configure the database schema.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Optional: Add model configurations here, if needed in future
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal async Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }

    public class User
    {
    }

    public class DbSet<T>
    {
        internal bool Any()
        {
            throw new NotImplementedException();
        }

        internal async Task FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        internal async Task<List<Product>> ToListAsync()
        {
            throw new NotImplementedException();
        }

        internal object Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }

    public class DbContextOptions<T>
    {
    }

    public class DbContext
    {
        private DbContextOptions<AppDbContext> options;

        public DbContext(DbContextOptions<AppDbContext> options)
        {
            this.options = options;
        }

        internal void OnModelCreating(ModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }
    }
}
