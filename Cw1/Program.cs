using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world"); // zad 3

            /*string bob = "Hello bob"; //zad 4
            string eva = "Hello eva"; // zad 4
            Console.WriteLine(bob + eva);*/

            /*string userName = Console.ReadLine(); // zad 5

            Console.WriteLine("Hello " + userName); //zad 5

            //Komentarz opisujący fragment kodu Kamil Chomej //zad 6
            */ // zad 8

            #region test_#region 
            Console.WriteLine("Test #region");
            #endregion //zad 7

            int a = 5;
            int b = 7;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b); // zad 9

            bool sprawdz = !true; //zad 10
            Console.WriteLine(sprawdz); // zad 11

            if(5 == 5)
            {
                Console.WriteLine("Wartości są równe");
            }

            if (4 < 5)
            {
                Console.WriteLine("Wartość pierwsza jest miejsza od drugiej");
            }

            if (6 > 5)
            {
                Console.WriteLine("Wartość pierwsza jest większa od drugiej");
            }

            if (4 != 5)
            {
                Console.WriteLine("Wartości są różne");
            } // zad 12


            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + " ");
            } // zad 15

            Console.WriteLine();

            int[] tab = new int[] { 1, 3, 2, 5 };

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            } //  Cwiczenia podpunkt 1/1

            Console.WriteLine();

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            } //  Cwiczenia podpunkt 1/2

            Console.WriteLine();


            for (int i = tab.Length - 1; i >= 0; i--)
            {
                Console.Write(tab[i] + " ");
            } //  Cwiczenia podpunkt 1/3

            Console.ReadLine();

        }
    }
}
