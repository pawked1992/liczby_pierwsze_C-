using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyPierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg liczb oddzielonych spocjami");
            string ciag_liczb = Console.ReadLine();
            lista_odpowiedzi(ciag_liczb);
            Console.ReadKey();
        }

        static void lista_odpowiedzi(string dane_wejsciowe)
        {
            List<string> dane_wyjsciowe = new List<string>();
            foreach (var liczba in konwersja_listy_string_na_int(dane_wejsciowe))
            {
                string linia_odpowiedzi = liczba.ToString();
                linia_odpowiedzi = (czy_pierwsza(liczba) == true) ? linia_odpowiedzi + "  -> TAK" : linia_odpowiedzi + "-> NIE";
                Console.WriteLine(linia_odpowiedzi);       
            }
        }

        static bool czy_pierwsza(int liczba)
        {
            int licznik = 0;
            if (liczba >= 1)
                for (int i = 1; i < liczba + 1; i++)
                    if (liczba % i == 0)
                    {
                        licznik++;
                    }

            bool x = (licznik == 2 || liczba == 1) ? true : false;
            return x;
        }

        static List<int> konwersja_listy_string_na_int(string ciag_liczb)
        {
            List<string> lista_stringow = ciag_liczb.Split(' ').ToList<string>();
            List<int> lista_liczb = new List<int>();
            foreach (var item in lista_stringow)
            {
                int var = 0;
                if (Int32.TryParse(item, out var))
                {
                    lista_liczb.Add(Int32.Parse(item));
                }
            }
            lista_liczb.Sort();
            return lista_liczb;
        }

        static void wyswietl_liste(List<int> lista_liczb)
        {
            foreach (var item in lista_liczb)
            {
                Console.WriteLine(item);
            }
        }
    }
}
