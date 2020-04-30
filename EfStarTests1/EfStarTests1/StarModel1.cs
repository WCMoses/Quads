namespace EfStarTests1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StarModel1 : DbContext
    {
        public StarModel1()
            : base("name=StarModel1")
        {
           
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StarModel1, Migrations.Configuration>());
        }

        public virtual DbSet<Star> Stars { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
