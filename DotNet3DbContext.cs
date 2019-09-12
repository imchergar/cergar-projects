using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet3
{
    class DotNet3Context : DbContext
    {
        public DotNet3Context()
            : base("DotNet3.Properties.Settings.DotNet3ConnectionString")
        {
        }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<StudentPredmet> StudentPredmet { get; set; }
    }
}
