using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Zadanie_4_klasy
{
    class ListaSlowKenku
    {
        static ListaSlowKenku kopiaListyKenku = new ListaSlowKenku();
        private List<string> listaSlow = new List<string>();
        public ListaSlowKenku()
        {
            for (int i = 0; i < File.ReadAllLines("listakenku.txt").Count(); i++)
            {
                listaSlow.Add(File.ReadAllLines("listakenku.txt")[i]);
            }
        }

        public void Funkcja(string i)
        {
            switch (i)
            {
                case "1":
                    WprowadzanieSlow();
                    break;
                case "2":
                    WyswSlowAlfabetycznie();
                    break;
                case "3":
                    ZnajdzCzyjest();
                    break;
                case "4":
                    TworzenieKopii();
                    Environment.Exit(0);
                    break;
            }
        }
        private void WprowadzanieSlow()
        {
            string slowo;
            while (1 == 1)
            {
                slowo = Console.ReadLine();
                if(listaSlow.Exists(x => x.Equals(slowo)))
                {

                }
                else
                {
                    if (slowo == " ")
                    {
                        break;
                    }
                    else
                    {
                        listaSlow.Add(slowo);
                    }
                }
            }
            File.WriteAllLines("listakenku.txt", listaSlow);
            Interfejs interfejs = Interfejs.StworzenieInterfejsu();
        }
        private void WyswSlowAlfabetycznie()
        {

            string[] alfabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "w", "x", "y", "z" };
            for (int i = 0; i < alfabet.Count(); i++)
            {
                List<string> slowa = new List<string>();
                Console.Write(alfabet[i] + ": ");
                for (int j = 0; j < listaSlow.FindAll(x => x.StartsWith(alfabet[i])).Count(); j++)
                {
                    slowa.Add(listaSlow.FindAll(x => x.StartsWith(alfabet[i]))[j]);
                }
                slowa.Sort();
                for (int j = 0; j < listaSlow.FindAll(x => x.StartsWith(alfabet[i])).Count(); j++)
                {
                    Console.Write(slowa[j] + ", ");
                }
                Console.WriteLine();
            }
            Interfejs interfejs = Interfejs.StworzenieInterfejsu();
        }

        private void ZnajdzCzyjest()
        {
            string slowo = Console.ReadLine();
            foreach(string el in listaSlow)
            {
                if (el.Contains(slowo))
                {
                    Console.Write(el + ", ");
                }
            }
            Console.WriteLine();
            Interfejs interfejs = Interfejs.StworzenieInterfejsu();
        }
        private void TworzenieKopii()
        {
            KopiaListyKenku(this);
            File.WriteAllLines("C:\\Users\\Kuba\\Desktop\\gry\\skruaw\\listakenku.txt", kopiaListyKenku.listaSlow);
        }
        static public void KopiaListyKenku(ListaSlowKenku oryginalListy)
        {
            kopiaListyKenku = oryginalListy;
        }
    }
}
