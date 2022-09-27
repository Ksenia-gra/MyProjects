using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4_GrafovaKL.Data
{
    internal class ApplicationContext:DbContext
    {
        public DbSet<User> DbUsers { get; set; }
        public DbSet<Progress> DbProgress { get; set; }
        public DbSet<Teory> DbTeory { get; set; }
        public DbSet<Question> DbQuestions { get; set; }
        public DbSet<Answer> DbAnswers { get; set; }
        public ApplicationContext() : base()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<ApplicationContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }
    }
}
