﻿using EvidencePojisteni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEvidencePojisteni
{
    public class Sprava
    {
        private List<PojisteneOsoby> osoby = new List<PojisteneOsoby>();


        public void PridatPojistence()
        {
            Console.WriteLine("Zadejte jméno pojisteneho:");
            string jmeno = Console.ReadLine();

            Console.WriteLine("Zadejte příjmení pojisteneho:");
            string prijmeni = Console.ReadLine();

            Console.WriteLine("Zadejte telefon pojisteneho:");
            string telefon = Console.ReadLine();

            Console.WriteLine("Zadejte věk pojisteneho (0-120):");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek) || vek < 0 || vek > 120)
            {
                Console.WriteLine("Neplatný věk. Zadejte věk mezi 0 a 120:");
            }

            var novyPojistenec = new PojisteneOsoby(jmeno, prijmeni, telefon, vek);
            osoby.Add(novyPojistenec);

            Console.WriteLine("Pojistenec byl úspěšně přidán.");
        }

        public void VypisPojistene()
        {
            if (osoby.Count == 0)
            {
                Console.WriteLine("Zadny pojistenec neni evidovan.");
                return;
            }
            Console.WriteLine("Seznam pojistenych osob:");
            foreach (var pojistenec in osoby)
            {
                Console.WriteLine($"{pojistenec.Jmeno} {pojistenec.Prijmeni}, Telefon: {pojistenec.Telefon}, Vek: {pojistenec.Vek}");
            }
        }

        public void VyhledatPojistene()
        {
            Console.WriteLine("Zadejte jméno:");
            string jmeno = Console.ReadLine()?.Trim();

            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = Console.ReadLine()?.Trim();

            var nalezeny = osoby.FirstOrDefault(o =>
                o.Jmeno.Equals(jmeno, StringComparison.OrdinalIgnoreCase) &&
                o.Prijmeni.Equals(prijmeni, StringComparison.OrdinalIgnoreCase)
            );

            if (nalezeny != null)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Nalezen:");
                Console.WriteLine($"Jméno: {nalezeny.Jmeno}");
                Console.WriteLine($"Příjmení: {nalezeny.Prijmeni}");
                Console.WriteLine($"Telefon: {nalezeny.Telefon}");
                Console.WriteLine($"Věk: {nalezeny.Vek}");
                Console.WriteLine("---------------------------------");
            }
            else
            {
                Console.WriteLine("Pojištěný nebyl nalezen.");
            }
        }
    }
}

