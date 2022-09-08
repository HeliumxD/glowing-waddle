using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zufallszahl_Spiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeat = "ja";
            do
            {
                ConsoleColor color1 = ConsoleColor.Green;
                int random; //Zufallszahl
                int UserNumber = 0; //ReadLine
                int trys = 1; //Anzahl Versuche
                int maximal; //grösste mögliche Zahl
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Willkommen beim");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" -Zahlen erraten Spiel-");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Welche maximal Zahl möchte sie haben? ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                maximal = Convert.ToInt32(Console.ReadLine());
                random = new Random().Next(1, maximal);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nEine zufällige Zahl wurde generiert");
                Console.Write("Versuchen sie diese Zahl zu erraten: ");
                while (random != UserNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    UserNumber = Convert.ToInt32(Console.ReadLine());
                    if (UserNumber <= maximal && UserNumber > random) //Falls Zahl grösser
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDie zufällige Zahl ist kleiner");
                        Console.ResetColor();
                    }
                    else if (UserNumber >= 0 && UserNumber < random) //Falls Zahl kleiner
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nDie zufällige Zahl ist grösser");
                        Console.ResetColor();
                    }
                    else if (UserNumber < 0 | UserNumber > maximal) //Falls Zahl über 100 oder unter 0
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nSie haben das Spiel nicht verstanden");
                        Console.ResetColor();
                    }
                    else
                    {
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Versuchen sie es nochmal: ");
                    trys++;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\nBravo! Sie haben die zufällige Zahl erraten");
                System.Threading.Thread.Sleep(1000);
                Console.Write("Die zufällige Zahl war: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(random);
                System.Threading.Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Sie haben ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(trys);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" Versuche gebraucht");
                Console.Write("Wollen sie nochmal spielen? [");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("ja");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("nein");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("] "); //Weiter spielen oder nicht
                Console.ForegroundColor = ConsoleColor.Magenta;
                repeat = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\n");
            } while (repeat == "ja");
        }
    }
}
