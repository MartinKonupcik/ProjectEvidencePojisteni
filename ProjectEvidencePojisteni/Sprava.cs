﻿using EvidencePojisteni;
using ProjectEvidencePojisteni;

public class Sprava
{
    private List<PojistenaOsoba> osoby = new List<PojistenaOsoba>();

    public void PridatPojistence()
    {
        Console.WriteLine("Zadejte jméno pojisteneho:");
        string jmeno = OperatorKonzole.NacteniNeprazdnehoStringu();

        Console.WriteLine("Zadejte příjmení pojisteneho:");
        string prijmeni = OperatorKonzole.NacteniNeprazdnehoStringu();

        Console.WriteLine("Zadejte telefon pojisteneho:");
        string telefon = OperatorKonzole.NacteniNeprazdnehoStringu();

        Console.WriteLine("Zadejte věk pojisteneho (0-120):");
        int vek;
        while (!int.TryParse(OperatorKonzole.NacteniNeprazdnehoStringu(), out vek) || vek < 0 || vek > 120)
        {
            Console.WriteLine("Neplatný věk. Zadejte věk mezi 0 a 120:");
        }

        var novyPojistenec = new PojistenaOsoba(jmeno, prijmeni, telefon, vek);
        osoby.Add(novyPojistenec);

        Console.WriteLine("Pojistenec byl úspěšně přidán.");
    }

    public void VypisPojistencu()
    {
        if (osoby.Count == 0)
        {
            OperatorKonzole.PojistenciNenalezeni();
            return;
        }
        OperatorKonzole.VypisPojistenych(osoby);
    }

    public void VyhledatPojistenceJmenoiPrijmeni()
    {
        Console.WriteLine("Zadejte Jmeno");
        string hledaneJmeno = OperatorKonzole.NacteniNeprazdnehoStringu();
        Console.WriteLine("Zadejte Příjmení");
        string hledanePrijmeni = OperatorKonzole.NacteniNeprazdnehoStringu();
        var nalezeniPojistenci = osoby.Where(o => o.Jmeno.Equals(hledaneJmeno, StringComparison.OrdinalIgnoreCase) && o.Prijmeni.Equals(hledanePrijmeni, StringComparison.OrdinalIgnoreCase)).ToList();
        ObsluhaVystupu(nalezeniPojistenci);
    }

    public void VyhledatPojistenceJmenoNeboPrijmeni()
    {
        Console.WriteLine("1- Jmeno");
        Console.WriteLine("2- Příjmení");
        var volba = Console.ReadKey().KeyChar;
        switch (volba)
        {
            case '1':
                Console.WriteLine();
                Console.WriteLine("Zadejte jméno:");
                string hledaneJmeno = OperatorKonzole.NacteniNeprazdnehoStringu();
                var nalezeniPojistenci = osoby.Where(o => o.Jmeno == hledaneJmeno).ToList();
                ObsluhaVystupu(nalezeniPojistenci);
                break;
            case '2':
                Console.WriteLine();
                Console.WriteLine("Zadejte příjmení:");
                string hledanePrijmeni = OperatorKonzole.NacteniNeprazdnehoStringu();
                var nalezeniPojistenciPrijmeni = osoby.Where(o => o.Prijmeni == hledanePrijmeni).ToList();
                ObsluhaVystupu(nalezeniPojistenciPrijmeni);
                break;
            default:
                Console.WriteLine("Neplatná volba. Zkuste to znovu.");
                break;
        }
    }

    public void ObsluhaVystupu(List<PojistenaOsoba> nalezeniPojistenci)
    {

        if (nalezeniPojistenci.Count > 1)
        {
            OperatorKonzole.VypisPojistenych(nalezeniPojistenci);
        }
        else if (nalezeniPojistenci.Count == 1)
        {
            OperatorKonzole.VypisPojistence(nalezeniPojistenci.Single());
        }
        else
        {
            OperatorKonzole.PojistenciNenalezeni();
        }
    }
}