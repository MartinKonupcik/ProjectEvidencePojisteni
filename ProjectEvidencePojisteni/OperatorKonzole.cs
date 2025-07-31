﻿using EvidencePojisteni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEvidencePojisteni
{
    public static class OperatorKonzole
    {
        public static void VypisPojistence(PojisteneOsoby pojistenaOsoba)
        {
            Console.WriteLine(pojistenaOsoba.ToString());
        }

        public static void VypisPojistenych(List<PojisteneOsoby> pojisteneOsoby)
        {
            if (pojisteneOsoby.Count == 0)
            {
                Console.WriteLine("Zadny pojistenec neni evidovan.");
                return;
            }

            Console.WriteLine("Seznam pojistenych osob:");
            foreach (var pojistenec in pojisteneOsoby)
            {
                VypisPojistence(pojistenec);
            }
        }

        public static void PojistenciNenalezeni()
        {
            Console.WriteLine("Pojistenec nebyl nalezen.");
        }

        public static string NacteniNeprazdnehoStringu()
        {
            string? text = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Zadejte neprázný text!!!");
                text = Console.ReadLine();
            }
            return text.Trim();
        }
    }
}
