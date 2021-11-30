using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak11_30_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double prosjek = 0;
            int zbroj = 0;
            int redniBroj = 1;
            int brojac = 0;
            int[] niz = new int[5];

            Console.WriteLine("Vjezba 2 - Klasei objekti\n");
            Console.WriteLine("Upisi 5 brojeva: \n");

            for(brojac = 0; brojac < niz.Length; brojac++)
            { 
                Console.WriteLine(redniBroj++ + " -broj");
                niz[brojac] = Convert.ToInt32(Console.ReadLine());
            }
            KlasaC objekt = new KlasaC();
            Console.WriteLine("Zbroj svih brojeva niza je: " + objekt.Zbroj(niz));
            Console.WriteLine("Prosjek svih brojeva niza je: " + objekt.Prosjek(niz));
            Console.ReadKey();
        }
    }

    class KlasaC
    {
        int zbroj;
        int prosjek;
     
        public int Zbroj(int[] niz) 
        {
            int zbroj = 0;
            
            for(int brojac = 0; brojac < niz.Length; brojac++)
            {
                zbroj += niz[brojac];
            }

            return zbroj;
        }

        public double Prosjek(int[] niz)
        {
            double zbroj = Zbroj(niz);
            double prosjek = zbroj / niz.Length;
            return prosjek;
        }
        


    }



}
