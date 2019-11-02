using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int n = 5;
            int k = 5;
            int m = 3;

            Console.WriteLine(opiszTyp(n));
            Console.WriteLine(opiszTyp(k, m));

            Console.ReadLine();*/ //zad 10


            Osoba dyrektor = new Osoba()
;
            dyrektor.imie = "JakiesImie";
            dyrektor.nazwisko = "JakiesImie";
            dyrektor.rokUrodzenia = 1973;
            dyrektor.waga = 90;
            dyrektor.wzrost = 190;
            dyrektor.okulary = true;
            dyrektor.plec1 = Osoba.plec.M;

            Console.WriteLine(dyrektor.imie);
            Console.WriteLine(dyrektor.nazwisko);
            Console.WriteLine(dyrektor.rokUrodzenia);
            Console.WriteLine(dyrektor.wzrost);
            Console.WriteLine(dyrektor.plec1); // zad 12,13,14,15

            Osoba pacjent = new Osoba();

            pacjent.wzrost = 150;
            pacjent.waga = 50;

            dyrektor.ObliczBmi(pacjent.wzrost,pacjent.waga);

            Console.ReadLine();
        }

        /*static int opiszTyp(int n)
        {
            return n;
        }

        static int opiszTyp(int k, int m)
        {
            return m + k;
        }*/ // zad 10
    }
}
