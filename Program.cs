
/*In diesem Program habe ich Datentyp double  und Methode ToDouble benutzt
  aber das Program funktioniert auch mit Datentyp float stadt double und
  Methode ToSinlge stadt ToDouble*/
/*On date 09.04.2021 I translated this Program on English Language 
 as practise for Git Hub*/
using System;

namespace Einsendeaufgabe3._5
{
    class Program
    {
        static void Main(string[] args)
        {
          
        
            Console.WriteLine("Permitted operations: \t \" + \"" +
                                                    "\t \" - \"" +
                                                    "\t \" * \"" +
                                                    "\t \" / \"" +
                                                    "\t \" : \"");
            double zahl1, zahl2;
            char operation;
            string ergebnis = "Result of your numbers is: {0} ";
            string text = "Enter number and press Enter:   ";

            Console.Write("First " + text);
            zahl1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter arithmetic operation and press enter: ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Second " + text);
            zahl2 = Convert.ToDouble(Console.ReadLine());

         



            switch (operation)
            {
                case '+':
                    Console.WriteLine(ergebnis, Addition(zahl1, zahl2));

                    break;

                case '-':
                    Console.WriteLine(ergebnis, Subtraktion(zahl1, zahl2));

                    break;

                case '*':
                    Console.WriteLine(ergebnis, Multiplikation(zahl1, zahl2));

                    break;

                case '/':
                    if (zahl1 != 0 && zahl2 != 0)
                    {
                        Console.WriteLine(ergebnis, Division(zahl1, zahl2));
                    }
                    else
                    {
                        Console.WriteLine("In dieser Operation Nummer 0 ist ungultig!!!");
                    }
                    break;
                case ':':
                    Console.WriteLine(ergebnis, Doppelnummer(zahl1, zahl2));

                    break;

                default:

                    Console.WriteLine("Operation Zeichen ist ungultig");
                    break;
            } // Ende switch Konstruktion

            Console.ReadKey();

        } //Ende Main Methode

        static double Addition(double zahl1, double zahl2)
        {
            return (zahl1 + zahl2);
        }

        static double Subtraktion(double zahl1, double zahl2)
        {
            return (zahl1 - zahl2);
        }

        static double Multiplikation(double zahl1, double zahl2)
        {
            return (zahl1 * zahl2);
        }

        static double Division(double zahl1, double zahl2)
        {
            return (zahl1 / zahl2);
        }

        static double Doppelnummer(double zahl1, double zahl2)
        {
           double zahl3 = 1; 
           for (int i = 0; i < zahl2; i++)
            {
                zahl3 = zahl3 * zahl1;
            }
            
            return (zahl3);
             
            
        } //Ende Doppelnummer
    } //Ende class Program
}


    

