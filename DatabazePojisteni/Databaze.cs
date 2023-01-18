using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabazePojisteni
{
    class Databaze
    {
        private List<Pojistenec> pojistenci;

        public Databaze()
        {
            pojistenci = new List<Pojistenec>();
        }

        public void PridejPojistence(string jmeno, string prijmeni, int telefon, int vek)
        {
            pojistenci.Add(new Pojistenec(jmeno, prijmeni, telefon, vek));
        }

        public void NajdiPojistence(string jmeno, string prijmeni)
        {
            foreach (Pojistenec p in pojistenci)
            {
                if (p.Jmeno == jmeno && p.Prijmeni == prijmeni)
                {
                    Console.WriteLine(p);
                    break;

                }
                
               
            }
            Console.WriteLine();
            Console.WriteLine("Pokračujte libovolnou klávesou.");
            
        }



        public void Vsichni ()
        {
            if (pojistenci.Count > 0)
            {
                foreach (Pojistenec p in pojistenci) 
                { 
                    Console.WriteLine(p);
                }
            }
            else
            {
                Console.WriteLine("Databáze je prázdná.");
            }

        }
    }  
}
