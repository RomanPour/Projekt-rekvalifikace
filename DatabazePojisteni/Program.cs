// See https://aka.ms/new-console-template for more information

using DatabazePojisteni;

Menu menu = new Menu();

char volba = '0';

while (volba != '4')
{
    menu.VypisMenu();
    volba = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (volba)
    { 
        case '1':
            menu.PridejPojistence();
        break;

        case '2':
            menu.VypisPojistence();
        break;

        case '3':
            menu.NajdiPojistence();
        break;

        case '4':
            Console.WriteLine("Program libovolnou klávesou ukončíte.");    
        break;

        default: 
            Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu");
        break;
    }
    
    Console.ReadKey();  
}


