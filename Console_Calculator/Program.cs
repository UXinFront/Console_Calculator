using System;
namespace ConCalcFull
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                /* Menu */
                Console.Clear();
                Console.WriteLine("Velkommen til ConCalc Version 2.0");
                Console.WriteLine("---------------------");
                Console.WriteLine("1. Plus");
                Console.WriteLine("2. Træk fra");
                Console.WriteLine("3. Gange");
                Console.WriteLine("4. Dividere");
                Console.WriteLine("5. Nettoløn");
                Console.WriteLine("6. Kørselsfradrag");
                Console.WriteLine("---------------------");
                Console.Write("Vælg funktion: ");
                string numberInput = Console.ReadLine();
                int numberPass = Convert.ToInt32(numberInput);

                /* plus */
                if (numberPass == 1)
                {
                    Console.Write("Indtast Tal 1: ");
                    double tal1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Indtast Tal 2: ");
                    double tal2 = Convert.ToDouble(Console.ReadLine());
                    double resultat = tal1 + tal2;
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Resultat: ");
                    Console.WriteLine(resultat);
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Esc for at afslutte program");
                }
                /* minus */
                if (numberPass == 2)
                {
                    Console.Write("Indtast det første tal: ");
                    double tal1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Indtast det tal du vil trække fra: ");
                    double tal2 = Convert.ToDouble(Console.ReadLine());
                    double resultat = tal1 - tal2;
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Resultat: ");
                    Console.WriteLine(resultat);
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Esc for at afslutte program");
                }
                /* gange */
                if (numberPass == 3)
                {
                    Console.Write("Indtast Tal 1: ");
                    double tal1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Indtast Tal 2: ");
                    double tal2 = Convert.ToDouble(Console.ReadLine());
                    double resultat = tal2 * tal1;
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Resultat: ");
                    Console.WriteLine(resultat);
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Esc for at afslutte program");
                }
                /* dividér */
                if (numberPass == 4)
                {
                    Console.Write("Indtast Tal 1: ");
                    double tal1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Indtast Tal 2: ");
                    double tal2 = Convert.ToDouble(Console.ReadLine());
                    double resultat = tal2 / tal1;
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Resultat: ");
                    Console.WriteLine(resultat);
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Esc for at afslutte program");
                }
                /* find nettoløn */
                if (numberPass == 5)
                {
                    Console.Write("Indtast din Brutto månedsløn: ");
                    double tal1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Indtast dit Månedsfradrag: ");
                    double tal2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Indtast Trækprocent: ");
                    double tal3 = Convert.ToDouble(Console.ReadLine());
                    double resultat = (tal1 - tal2) * ((100 - tal3) / 100);
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Din Nettoløn: ");
                    Console.WriteLine(resultat);
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Esc for at afslutte program");
                }
                if (numberPass == 6)
                {
                    double fradrag = 0;
                    double fradrag2 = 0.99;

                    Console.Write("Bor du i en yderkommune? (skriv ja eller nej): ");
                    string yderKommune = Console.ReadLine().Trim().ToLower();
                    Console.Write("Antal arbejdsdage om året: ");
                    double tal1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Antal kilometer til arbejde: ");
                    double tal2 = Convert.ToDouble(Console.ReadLine());

                    double km = tal2 - 24;


                    if (km <= 0) //hvis mindre end de nødvendige 24 km for fradrag
                    {
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Du kan rende og hoppe. ");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Esc for at afslutte program");
                    }
                    else if (yderKommune == "ja" || yderKommune == "j")
                    {
                        fradrag = 1.98;
                        int resultat = Convert.ToInt32 (tal1 * (km * fradrag));
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Dit Kørselsfradrag: ");
                        Console.WriteLine(resultat);
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Esc for at afslutte program");
                    }
                    else if (km - 96 > 0)
                    {
                        double under120 = 96 * 1.98;
                        double over120 = ((km - 96) * fradrag2);
                        int resultat = Convert.ToInt32 (tal1 * (over120 + under120));
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Dit Kørselsfradrag: ");
                        Console.WriteLine(resultat);
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Esc for at afslutte program");
                    }
                    else if (km - 96 <= 0)
                    {
                        fradrag = 1.98;
                        int resultat = Convert.ToInt32 (tal1 * (km * fradrag));
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Dit Kørselsfradrag: ");
                        Console.WriteLine(resultat);
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Esc for at afslutte program");
                    }


                }
                cki = Console.ReadKey();

            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}