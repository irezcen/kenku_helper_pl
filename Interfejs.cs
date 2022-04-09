using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_4_klasy
{
    class Interfejs
    {
        private Menu menu;
        public static int iloscOpcji = 4;
        public static string[] opcje = {"wprowadz slowo", "wywietl alfabetycznie", "znajdz czy jest w liscie", "koniec" };
        public static void WyswOpcje()
        {
            for(int i  = 1; i<= iloscOpcji; i++)
            {
                Console.WriteLine(opcje[i-1]+"-->"+i);
            }
        }
        private Interfejs() {}
        public static Interfejs StworzenieInterfejsu()
        {
            WyswOpcje();
            return new Interfejs()
            {
                menu = new Menu(Interfejs.iloscOpcji, Console.ReadLine())
            };
        }
    }
}
