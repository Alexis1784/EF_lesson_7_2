using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_7_2
{
    class MobileContext : DbContext
    {
        public MobileContext()
            : base("EF_lesson_7_2")
        { }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Smartphone> Smarts { get; set; }
    }
}
