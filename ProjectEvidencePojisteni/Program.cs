﻿using ProjectEvidencePojisteni;

var sprava = new Sprava();

Console.WriteLine("---------------------------------");
Console.WriteLine("Evidence Pojistenych");
Console.WriteLine("---------------------------------");

char choice = '0';
while (choice != '5')
{
    Console.WriteLine();
    Console.WriteLine("Vyberte si akci:");
    Console.WriteLine("1 - Přidat nového pojištěného");
    Console.WriteLine("2 - Vypsat všechny pojištěné");
    Console.WriteLine("3 - Vyhledat pojištěného podle jmena i přijmeni");
    Console.WriteLine("4 - Vyhledat pojištěného podle jmena nebo přijmeni");
    Console.WriteLine("5 - Konec");

    choice = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (choice)
    {
        case '1':
            
            break;

        case '2':
            
            break;

        case '3':
           
            break;

        case '4':
            
            break;
        case '5':
            Console.WriteLine("Děkuji za použití aplikace.");
            break;

        default:
            Console.WriteLine("Neplatná volba. Zkuste to znovu.");
            break;

    }
}