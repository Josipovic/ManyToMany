using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            SkolaContext db = new SkolaContext();
            Predmet mat = new Predmet();
            Predmet fiz = new Predmet();
            mat.Naziv = "Matematika";
            fiz.Naziv = "Fizika";
            Ucenik u = new Ucenik();
            u.Ime = "Ivo";
            Ucenik u1 = new Ucenik();
            u1.Ime = "Ivan";
            Ucenik u2 = new Ucenik();
            u2.Ime = "Mario";


            //ivo ide na mat i fiz
            //ivan ide na fiz
            //mario ide na mat

            u.Predmeti.Add(mat);
            u.Predmeti.Add(fiz);

            u1.Predmeti.Add(fiz);
            //ili
            //fiz.Ucenici.Add(u1);

            u2.Predmeti.Add(mat);

            db.Predmeti.Add(mat);
            db.Predmeti.Add(fiz);


            //ili
            db.Ucenici.Add(u1);
            db.Ucenici.Add(u2);
            db.Ucenici.Add(u);
            //db.SaveChanges();

            foreach (var p in db.Predmeti) {
                Console.WriteLine(p.Naziv);
                foreach (var s in p.Ucenici) {
                    Console.WriteLine("      " +s.Ime);
                }

            }
            Console.Read();
        }
    }
}
