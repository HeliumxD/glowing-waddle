using System;
using System.CodeDom;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;
using System.Timers;

namespace Zufallszahl_Spiel
{
    internal class Program
    {
        static ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        static Random r = new Random();
        static bool colorfull = false;
        static void print(string s)
        {
            if (colorfull == true)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    int j = r.Next(1, colors.Length);
                    Console.ForegroundColor = colors[j];
                    Console.Write(s[i]);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(s);
            }
        }
        static void Main(string[] args)
        {
            string repeat = "ja";
            do
            {
                int highscore = 100000; //Bester Versuch
                TimeSpan rekord = new TimeSpan(1,0,0); //Beste Zeit
                do
                {
                    int random; //Zufallszahl
                    int userNumber = 0; //Eingabe
                    int trys = 1; //Anzahl Versuche
                    int maximal = 0; ; //grösste mögliche Zahl
                    DateTime start = DateTime.Now;
                    Program.print("Willkommen beim\t-Zahlen erraten Spiel-\n");
                    Program.print("Möchetn sie ein farbiges Spiel haben? [ja|nein]\n");

                    if (Console.ReadLine() == "ja") { colorfull = true; }
                    else { colorfull = false; }

                    Program.print("Welche maximal Zahl möchten sie haben? "); //Limit der zufälligen Zahl
                    try
                    {
                        maximal = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Program.print("Ungültige Eingabe. Das Spiel wird geschlossen\n\n");
                    }

                    random = new Random().Next(1, maximal); //Generierung der zufälligen Zahl
                    Program.print("\n\nEine zufällige Zahl wurde generiert\n");
                    Program.print("Versuchen sie diese Zahl zu erraten: ");
                    try
                    {
                        while (random != userNumber)
                        {
                            userNumber = Convert.ToInt32(Console.ReadLine());
                            if (userNumber <= maximal && userNumber > random) //Falls Zahl grösser
                            {
                                Program.print("\nDie zufällige Zahl ist kleiner");
                            }
                            else if (userNumber >= 0 && userNumber < random) //Falls Zahl kleiner
                            {
                                Program.print("\nDie zufällige Zahl ist grösser");
                            }
                            else if (userNumber < 0 | userNumber > maximal) //Falls Zahl über dem Limit oder unter 0
                            {
                                Program.print("\nZahl ist ausserhalb des Limits");
                            }
                            else
                            {
                                Program.print("Ungültige Eingabe. Das Spiel wird geschlossen");
                            }
                            Program.print("\nVersuchen sie es nochmal: ");
                            trys++;
                        }
                    }
                    catch
                    {
                        Program.print("Ungültige Eingabe. Das Spiel wird geschlossen\n\n");
                    }

                    DateTime stop = DateTime.Now;
                    TimeSpan delta = stop - start;
                    Program.print("\n\nBravo! Sie haben die zufällige Zahl erraten\n");
                    System.Threading.Thread.Sleep(1000);

                    if (trys < highscore)
                    {
                        highscore = trys;
                    }
                    if (delta < rekord)
                    {
                        rekord = delta;
                    }

                    Program.print("Die zufällige Zahl war: " + Convert.ToString(random) + "\n");
                    System.Threading.Thread.Sleep(1000);
                    Program.print("Sie haben " + Convert.ToString(trys) + " Versuche gebraucht\n");
                    Program.print("Ihr Rekord ist bei " + highscore + " Versuchen\n");
                    Program.print("Sie haben " + delta + " sekunden gebraucht\n");
                    Program.print("Ihr Bester Versuch ist bei " + rekord + " sekunden");
                    Program.print("Wollen sie nochmal spielen? [ja|nein] "); //Weiter spielen oder nicht
                    try
                    {
                        repeat = Console.ReadLine();
                    }
                    catch
                    {
                        Program.print("Ungültige Eingabe. Das Spiel wird geschlossen\n\n");
                    }
                    Program.print("\n\n");
                } while (repeat == "ja");
            } while (repeat == "ja");
        }
    }
}
.
