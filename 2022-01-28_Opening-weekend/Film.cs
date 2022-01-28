using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_01_28_Opening_weekend
{
    class Film
    {
        public string EredetiCim { get; set; }
        public string MagyarCim { get; set; }
        public string Bemutato { get; set; }
        public string Forgalmazo { get; set; }
        public int Bevetel { get; set; }
        public int Latogato { get; set; }

        public Film(string sor)
        {
            string[] t = sor.Split(';');
            EredetiCim = t[0];
            MagyarCim = t[1];
            Bemutato = t[2];
            Forgalmazo = t[3];
            Bevetel = int.Parse(t[4]);
            Latogato = int.Parse(t[5])




        }
    }
}
