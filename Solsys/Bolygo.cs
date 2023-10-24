using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solsys
{
    class Bolygo
    {
        private string nev;
        private int holdSzam;
        private double terfogatA;

        public string Nev { get => nev ; }
        public int HoldakSzama { get => holdSzam; }
        public double TerfogatA { get => terfogatA; }

        public Bolygo(string sor)
        {
            string[] s = sor.Split(';');
            nev = s[0];
            holdSzam = int.Parse(s[1]);
            terfogatA = double.Parse(s[2].Replace('.', ','));
        }

    }
   
}
