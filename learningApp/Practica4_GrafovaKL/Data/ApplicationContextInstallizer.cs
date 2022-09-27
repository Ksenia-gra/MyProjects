using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4_GrafovaKL.Data
{
    internal class ApplicationContextInstallizer:SqliteDropCreateDatabaseAlways<ApplicationContext>
    {
        public ApplicationContextInstallizer(DbModelBuilder modelBuilder)
            : base(modelBuilder) { }

        protected override void Seed(ApplicationContext context)
        {
        }
    }
}
