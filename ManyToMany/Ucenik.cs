using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany
{
    public class Ucenik
    {
        public int Id { get; set; }
        public  string  Ime { get; set; }

        public  virtual List<Predmet>Predmeti { get; set; }

        public Ucenik()
        {
            Predmeti = new List<Predmet>();
        }
    }
}
