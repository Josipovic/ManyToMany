using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany
{
   public  class Predmet
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        //navigacijsko svojstvo
        public virtual List<Ucenik>Ucenici { get; set; }

        public Predmet()
        {
            Ucenici = new List<Ucenik>();
        }
    }
}
