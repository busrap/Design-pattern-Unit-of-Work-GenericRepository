using Personel_Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Dal
{
    public class PersonelContext:DbContext
    {
        public PersonelContext():base("PersonelContext")
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Personel_> Personels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
