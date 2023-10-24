using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solsys
{
    class Program
    {
        static List<Bolygo> bolygok = new List<Bolygo>();
        static void Main(string[] args)
        {

            using (var sr = new StreamReader(@"..\..\src\solsys.txt", Encoding.UTF8)) 
            {

                while (!sr.EndOfStream)
                    bolygok.Add(new Bolygo(sr.ReadLine()));

            }
            
            Console.WriteLine($"1.Feladat: {bolygok.Count} bolygó van a naprendszerben");



            var atlagH = bolygok.Average(b1 => b1.HoldakSzama);
            Console.WriteLine($"2.Feladat: A naprendszerben egy bolygónak átlagosan {atlagH} holdja van.");



            var lgtfBoly = bolygok.SingleOrDefault(b2 => b2.TerfogatA == bolygok.Max(b3 => b3.TerfogatA));
            Console.WriteLine($"3.Feladat: A legnagyobb térfogatú bolygó a {lgtfBoly.Nev}");



            Console.Write($"4.feladat: írd be a keresett bolygó nevét: ");
            var bolyN = Console.ReadLine();
            Console.WriteLine(bolygok.SingleOrDefault(b4 => b4.Nev == bolyN) != null ?
                "van ilyen bolygó." :
                " nincs ilyen nevű bolygó .");



            Console.Write($"5.Feladat: Írj be egy egész számot: ");
            var szam = int.Parse(Console.ReadLine());
            var tobbH = bolygok.Where(b5 => b5.HoldakSzama > szam).Select(b5 => b5.Nev).ToArray();
            Console.WriteLine("A következő bolygóknak van 10-nál/nél több holdja:");
            foreach (var i in tobbH)
                Console.Write($"{i}, ");

            Console.ReadKey(true);
        }
       
 
    }
    
}

