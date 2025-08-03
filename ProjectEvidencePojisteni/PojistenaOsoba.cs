using System.ComponentModel.DataAnnotations;

namespace EvidencePojisteni
{
    public class PojistenaOsoba
    {
        public int CisloPojistence { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Telefon { get; set; }
        public int Vek { get; set; }

        public PojistenaOsoba(string jmeno, string prijmeni, string telefon, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Telefon = telefon;
            Vek = vek;
        }
        public override string ToString()
        {
            return $"{CisloPojistence}, {Jmeno} {Prijmeni}, Telefon: {Telefon}, Vek: {Vek}";
        }
    }
}