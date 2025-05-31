using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppParking
{
    class Menu
    {
        public string login;
        public string haslo;
        private string action;
        private string miejsce;
        public Menu()
        {

        }

        public void LogPage()
        {
            Console.Clear();
            Console.WriteLine("Aplikacja Rezerwacje Parkingu");

            Console.Write("Login:");
            login = Console.ReadLine();
            Console.Write("Hasło:");
            haslo = Console.ReadLine();
        }

        public void mainMenu(User u)
        {
            Console.Clear();
            Console.WriteLine("Witaj " + u.userName + "!");
            Console.WriteLine("Wybierz akcję którą chcesz wykonać: ");
            Console.WriteLine("1. Sprawdź dostępność miejsc");
            Console.WriteLine("2. Wyloguj się");
            this.mainMenuAction(u);
        }

        public void mainMenuAction(User u)
        {
            action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    Console.WriteLine("Podaj numer miejsca: ")
                    miejsce = Console.ReadLine();
                    MiejsceParkingowe MP = new MiejsceParkingowe(miejsce);
                    MP.sprawdzDostepnosc();
                    break;
                case "2":
                    u.isLoged = false;
                    Console.WriteLine("pomyślnie wylogowano! Kliknij dowolny klawisz aby wrócić do logowania");
                    Console.ReadKey();
                    this.LogPage();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Podano nie właściwą akcję!");
                    Console.ReadKey();
                    this.mainMenu(u);
                    break;
            }
        }
    }
}
