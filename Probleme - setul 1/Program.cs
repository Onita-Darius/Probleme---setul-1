using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Probleme___setul_1
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Selecteaza nr. exercituiului");
            Console.WriteLine("----------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            int Ex = 0;
            Ex = Convert.ToInt16(Console.ReadLine());

            if (Ex == 1) Ex1();
            if (Ex == 2) Ex2();
            if (Ex == 3) Ex3();
            if (Ex == 4) Ex4();
            if (Ex == 5) Ex5();
            if (Ex == 6) Ex6();
            
            else
            {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Nu exista acel exercitiu");
            }
    Main();
        }

        private static void Ex6()
        {

            ///Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.
            Console.WriteLine("Scrieti 3 numere naturale pe o singura linie");
            int a, b, c;

            string nr;

            nr = Console.ReadLine();

            char[] separator = new char[] { ' ', ',', ';' };

            string[] x = nr.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            a = int.Parse(x[0]);
            b = int.Parse(x[1]);
            c = int.Parse(x[2]);

            if (a < b + c && b < a + c && c < a + b)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("a, b si c pot fi lungimile laturilor unui triunghi");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("a, b si c nu pot fi lungimile laturilor unui triunghi");
            }
               
            Main();
        }


        private static void Ex5()
        {
            /// Extrageti si afisati a k - a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("WorkInProgres");


            int k;
            string n;
            Console.WriteLine("Alege nr.");
            n = Console.ReadLine();
            Console.WriteLine("A cata cifra sa fie extrasa");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine($"Se va scoate a {k} cifra din nr. {n}");

            string[] nr = n.Split();
            Main();


        }

        private static void Ex4()
        {
            ///Detreminati daca un an y este an bisect. 

            Console.WriteLine("Scrieti anul");
            int an = int.Parse(Console.ReadLine());
            if (an % 4 == 0)
            {
                if (an % 100 == 0)
                {
                    if (an % 400 == 0) Console.WriteLine($"{an} este an bisect");
                    else Console.WriteLine($"{an} nu este an bisect");
                }
                else Console.WriteLine($"{an} este an bisect");
            }
            else Console.WriteLine($"{an} nu este an bisect");
            Main();
        }

        private static void Ex3()
        {
            /// Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
            Console.WriteLine("Scrie n si k");
            string termeni;
            termeni = Console.ReadLine();
            char[] separator = new char[] { ' ', ',', ';' };
            string[] nk = termeni.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);

            if (n % k == 0)
            {
                Console.WriteLine($"{n} se divide cu {k}");
            }
            else Console.WriteLine($"{n} nu se divide cu {k}");
            Main();
        }

        private static void Ex2()
        {
            ///Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax ^ 2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.
            Console.WriteLine("Pentru formula 'ax^2 + bx + c = 0' alege a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pentru formula 'ax^2 + bx + c = 0' alege b ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pentru formula 'ax^2 + bx + c = 0' alege c ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");
            int x1;
            int x2;
            int Delta = (b * b) - 4 * a * c;
            if (Delta < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("x nu este un numar real");
                Console.ResetColor();
            }
            if (Delta == 0 || Delta > 0)
            {
                int RadDelt = (int)Math.Sqrt(Delta);
                x1 = (-b + RadDelt) / 2 * a;
                x2 = (-b - RadDelt) / 2 * a;
                Console.WriteLine($"Solutiile pentru '{a}x^2 + {b}x + {c} = 0'");
                Console.WriteLine($"Sunt x1 = {x1} si x2 = {x2} ");
            }

            Main();
        }

        private static void Ex1()
        {
            ///Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
            Console.WriteLine("Pentru formula 'ax+b = 0' alege a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pentru formula 'ax+b = 0' alege b ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} x + {b} = 0");
            int x = 0 - b / a;
            Console.WriteLine($"x = {x}");
            Main();
        }
    }
    
}
