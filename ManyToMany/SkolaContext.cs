using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany
{
    class SkolaContext:DbContext
    {
        public  DbSet<Ucenik>Ucenici { get; set; }
        public  DbSet<Predmet>Predmeti { get; set; }
    }
}
