using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppParking
{
    class MiejsceParkingowe
    {
        private string numer;
        private string lokalizacja;
        private decimal cenaZaGodzine;
        private bool dostepnosc;
        private string[] bazaMiejsc;

        public MiejsceParkingowe(string numer)
        {
            this.numer = numer;
            pobierzListeMiejsc();
        }
        public void pobierzListeMiejsc()
        {
            string plik = "../../../miejscaParkingowe.txt";
            bazaMiejsc = File.ReadAllLines(plik);
        }
        public void sprawdzDostepnosc()
        {
            foreach()
        }
    }
}
