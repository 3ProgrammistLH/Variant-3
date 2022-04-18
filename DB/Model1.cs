using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Кокарев_Вариант_3
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model3V")
        {
        }

        public virtual DbSet<Drivers> Drivers { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
