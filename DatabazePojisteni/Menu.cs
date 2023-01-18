using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabazePojisteni
{
     class Menu
    {
        private Databaze databaze;

        public Menu()
        { 
        databaze= new Databaze();
        }

        public void PridejPojistence()
        {
            Console.WriteLine();
            Console.WriteLine("Zadejte jméno pojištěnce:");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine().Trim()))
            {
                Console.WriteLine("Zadejte jméno znovu:");
            }
            Console.WriteLine("Zadejte příjmení pojištěnce:");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine().Trim()))
            {
                Console.WriteLine("Zadejte jméno znovu:");
            }
            Console.WriteLine("Zadejte věk pojištence:");
            int vek;
            while (!int.TryParse(Console.ReadLine().Trim(), out vek))
            {
                Console.WriteLine("Není číslo, zadejte prosím znovu:");
            }
            Console.WriteLine("Zadejte telefonní číslo pojištěnce (bez mezer):");
            int telefon;
            while (!int.TryParse(Console.ReadLine().Trim(), out telefon))
            {
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");
            }

            databaze.PridejPojistence(jmeno, prijmeni, vek, telefon);
            Console.WriteLine();
            Console.WriteLine("Záznam byl přidán, stiskněte libovolnou klávesu.");
            
        }

        public void NajdiPojistence()
        {
            Console.WriteLine("Zadejte jméno pojištěnce:");
            string hledejJmeno;
            while (string.IsNullOrWhiteSpace(hledejJmeno = Console.ReadLine().Trim()))
            {
                Console.WriteLine("Zadejte jméno znovu:");
            }
            Console.WriteLine("Zadejte příjmení pojištěnce:");
            string hledejPrijmeni;
            while (string.IsNullOrWhiteSpace(hledejPrijmeni = Console.ReadLine().Trim()))

            {
                Console.WriteLine("Zadejte příjmení znovu:");
            }
            Console.WriteLine();
            databaze.NajdiPojistence(hledejJmeno, hledejPrijmeni);
        }

        public void VypisPojistence()
        {
            Console.WriteLine();
            Console.WriteLine("Seznam všech pojištěných");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            databaze.Vsichni();
            Console.WriteLine();
            Console.WriteLine("Pokračujte libovolnou klávesou.");
        }

            public void VypisMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("||         EVIDENCE POJIŠTĚNÝCH        ||");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Vyberte si akci:");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojištěného");
            Console.WriteLine("4 - Konec");
            Console.WriteLine();
        }
    }
}
