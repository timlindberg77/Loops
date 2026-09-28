using System.Runtime.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa en konsolapplikation som genererar och visar multiplikationstabellen
            //för ett givet tal. Användaren matar in ett tal och programmet skriver ut
            //multiplikationstabellen för det numret från 1 till 10.
            //Instruktioner:
            //• Be användaren att ange ett nummer.
            //• Använd en for-loop för att iterera från 1 till 10.
            //• Inuti loop, multiplicera inmatningstalet med det aktuella iterationsvärdet
            //(loopvariabel).
            //• Skriv ut varje rad i multiplikationstabellen i formatet :
            //[input number] x [current number] = result
            //Console.WriteLine("Skriv ett nummer");
            //int InputNummer = int.Parse(Console.ReadLine());

            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine($" {InputNummer} x {i} = {InputNummer * i}");
            //}

            //Skapa en enkel konsolapplikation där användaren måste gissa ett
            //slumpmässigt genererat nummer inom ett specifikt range. Programmet
            //kommer att ge feedback om gissningen är för hög, för låg eller korrekt.
            //Använd en while-loop för att låta användaren fortsätta gissa tills de hittar
            //rätt nummer.
            //Instruktioner:
            //• Generera ett slumptal mellan 1 och 100.
            //• Be användaren att gissa numret.
            //• Använd en while-loop för att fortsätta be om gissningar tills användaren
            //gissar rätt nummer.
            //• Ge feedback för varje gissning:
            //• Om gissningen är lägre än det genererade antalet, skriv ut "För lågt!"
            //• Om gissningen är högre än det genererade numret, skriv ut "För högt!"
            //• Om gissningen är korrekt, skriv ut "Grattis! Du gissade siffran!"
            //• Om du vill kan du hålla reda på hur många försök det tar för användaren
            //att gissa rätt antal.
                //genererar ett random nummer
                Random RandomNummer = new Random(); 
                int tal = RandomNummer.Next(1, 101);
                //antalet gissningar
                int Antalgissningar = 0; 
                int gissning = 0;
                Console.WriteLine("Gissa ett tal mellan 1-100");
                while (gissning != tal)
                {
                    gissning = int.Parse(Console.ReadLine());
                    Antalgissningar++;
                    //ifall det gissar för högt
                    if (gissning > tal)
                    {
                        Console.WriteLine("För högt!");
                    }
                    //ifall de gissar för lågt
                    else if (gissning < tal)
                    {
                        Console.WriteLine("För lågt!");
                    }
                    //gissar det rätt
                    else
                    {
                        Console.WriteLine("Du Gissade rätt");
                        Console.WriteLine($"Du gissade {Antalgissningar} gånger");
                    }

                }           
        }
    }
}
