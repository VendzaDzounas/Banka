using System;
using System.Collections.Generic;

namespace Banka
{
    class Banka
    {
        private string nazev;
        private string lokalita;
        private List<Ucet> ucty_banky = new List<Ucet>();

        public Banka(string Nazev, string Lokalita)
        {
            nazev = Nazev;
            lokalita = Lokalita;
        }
        public void Pridej_Ucet(Ucet ucet)
        {
            ucty_banky.Add(ucet);
        }
        public void Vypis_Informaci_Uctu()
        {
            Console.WriteLine("Počet účtů v bance: " + ucty_banky.Count);
            for (int i = 0; i < ucty_banky.Count; i++)
            {
                ucty_banky[i].Vypis_Uctu();
            }
        }
        public void Odeber_Ucet(int index_uctu)
        {
            ucty_banky.RemoveAt(index_uctu);
        }
    }
    class Ucet
    {
        private string vlastnik;
        private int penize;
        private int cislo_uctu;

        public Ucet(string Vlastnik, int Penize, int Cislo_Uctu)
        {
            vlastnik = Vlastnik;
            penize = Penize;
            cislo_uctu = Cislo_Uctu;
        }

        public void Vklad(int vklad)
        {
            penize += vklad;
        }
        public void Vyber(int vyber)
        {
            penize -= vyber;
        }
        public void Vypis_Uctu()
        {
            Console.WriteLine("Vlastník: " + vlastnik + " | Peníze na účtu: " + penize + " | Číslo účtu: " + cislo_uctu);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ucet ucet1 = new Ucet("Pepa", 5000, 1);
            Ucet ucet2 = new Ucet("Franta", 10000, 2);

            Banka Ceska_Sporitelna = new Banka("Česká Spořitelna", "Orlová");

            Ceska_Sporitelna.Pridej_Ucet(ucet1);
            Ceska_Sporitelna.Pridej_Ucet(ucet2);
            Ceska_Sporitelna.Vypis_Informaci_Uctu();

            Console.WriteLine();
            Ceska_Sporitelna.Odeber_Ucet(0);
            Ceska_Sporitelna.Vypis_Informaci_Uctu();

            Ucet ucet3 = new Ucet("Lojza", 2500, 3);
            Ucet ucet4 = new Ucet("Tereza", 7500, 4);

            Ceska_Sporitelna.Pridej_Ucet(ucet3);
            Ceska_Sporitelna.Pridej_Ucet(ucet4);
            Ceska_Sporitelna.Vypis_Informaci_Uctu();
        }
    }
}
