using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebFormCRUD.Model;
using WebFormCRUD.Model.Views;

namespace WebFormCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DbConnection")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Migrations.Configuration>());
        }

        public DbSet<University> University { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<ShowStudentsView> StudentListView { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}