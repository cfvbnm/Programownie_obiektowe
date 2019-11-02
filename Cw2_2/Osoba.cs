using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw2_2
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public double waga;
        public double wzrost;
        public bool okulary;
        public plec plec1;

        public enum plec { K, M }
        
        public int ObliczWiek(int rokUrodzenia)
        {
            int obecnyRok = DateTime.Now.Year;
            int rokUro = rokUrodzenia;
            int wynik = obecnyRok - rokUro;

            return wynik;
        }

        public void ObliczBmi(double wzrost, double waga)
        {
            double bmi = waga / ((wzrost / 100) * (wzrost / 100));
            Console.WriteLine("BMI wynosi:" + bmi); // zad 16
            if(bmi < 16)
            {
                Console.WriteLine("Wygłodzenie");
            }

            else if (bmi >= 16 && bmi <= 16.99 )
            {
                Console.WriteLine("Wychudzenie");
            }

            else if (bmi >= 17 && bmi <= 18.49)
            {
                Console.WriteLine("Niedowaga");
            }

            else if (bmi >= 18.5 && bmi <= 24.99)
            {
                Console.WriteLine("Pożądana masa ciała");
            }
            else if (bmi >= 25 && bmi <= 29.99)
            {
                Console.WriteLine("Nadwaga");
            }

            else if (bmi >= 30 && bmi <= 34.99)
            {
                Console.WriteLine("Otyłość 1 stopnia");
            }
            else if (bmi >= 35 && bmi <= 39.99)
            {
                Console.WriteLine("Otyłość 2 stopnia");
            }
            else if (bmi >= 40)
            {
                Console.WriteLine("Otyłość 3 stopnia");
            }
        }
    }
}
