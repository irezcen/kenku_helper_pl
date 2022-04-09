using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Zadanie_4_klasy
{
    class Menu
    {
        private ListaSlowKenku listaKenku;
        public Menu(int liczbaOpcji, string wyborUzytkwnika)
        {
            listaKenku = new ListaSlowKenku();
            for(int i = 1; i <= liczbaOpcji; i++)
            {
                if (Convert.ToInt32(wyborUzytkwnika) == i)
                {
                    listaKenku.Funkcja(Convert.ToString(i));
                }
            }
        }

    }
}
