using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Passwort Abfrage
            PasswortAbfrage abfrage1 = new PasswortAbfrage();
            Console.Write("Benutzernamen eingeben: ");
            abfrage1.benutzername=Console.ReadLine();
            Console.WriteLine("Dein Benutzername ist: " + abfrage1.benutzername);

            Console.WriteLine("");

            PasswortAbfrage abfrage2 = new PasswortAbfrage();
            Console.Write("Passwort eingeben: ");
            abfrage2.pw = Console.ReadLine();
            Console.WriteLine("Dein Passwort ist: " + abfrage2.pw);

            Console.WriteLine("");

            Console.WriteLine("Ist dies korrekt?");
            PasswortAbfrage abfrage3 = new PasswortAbfrage();
            abfrage3.antwortK = Console.ReadLine();
            if (abfrage3.antwortK=="ja" || abfrage3.antwortK=="Ja")
            {
                Console.Clear();
            }
            if (abfrage3.antwortK=="nein" || abfrage3.antwortK=="Nein" || abfrage3.antwortK == "")
            {
                return;
            }
            #endregion

            #region QUIZZ
            Console.WriteLine("The Quizz");
            Console.WriteLine("---");
            Quizz frage1 = new Quizz();
            Quizz jaNein=new Quizz();
            jaNein.ausgabe = true;
            Console.WriteLine("Gibt es blaue Paprikas?");
            frage1.antwort = Console.ReadLine();
            
            if (frage1.antwort=="nein" || frage1.antwort=="Nein")
            {
                jaNein.ausgabe = true;
                Console.WriteLine("");
                Console.WriteLine("Richtig!");
                Console.WriteLine("");
            }
            if (frage1.antwort=="ja" || frage1.antwort == "Ja" || frage1.antwort == "")
            {
                jaNein.ausgabe = false;
                Console.WriteLine("");
                Console.WriteLine("Falsch!");
                Console.WriteLine("");
            }
            if (jaNein.ausgabe == true)
            {
                Console.WriteLine("Nächste Frage:");
            }
            if (jaNein.ausgabe == false)
            {
                Console.WriteLine("Gib auf!");
            }

            Quizz frage2 = new Quizz();
            Console.WriteLine("Gibt es Capybaras?");
            frage2.antwort2 = Console.ReadLine();

            if (frage2.antwort2 == "ja" || frage2.antwort2 == "Ja")
            {
                jaNein.ausgabe = true;
                Console.WriteLine("");
                Console.WriteLine("Richtig!");
                Console.WriteLine("");
            }
            if (frage2.antwort2 == "nein" || frage2.antwort2 == "Nein" || frage2.antwort2 == "")
            {
                jaNein.ausgabe = false;
                Console.WriteLine("");
                Console.WriteLine("Falsch!");
                Console.WriteLine("");
            }
            if (jaNein.ausgabe == true)
            {
                Console.WriteLine("Nächste Frage:");
            }
            if (jaNein.ausgabe == false)
            {
                Console.WriteLine("Gib auf!");
            }

            Quizz frage3 = new Quizz();
            Console.WriteLine("Gibt es Capybaras?");
            frage3.antwort3 = Console.ReadLine();

            if (frage3.antwort3 == "ja" || frage3.antwort3 == "Ja")
            {
                jaNein.ausgabe = true;
                Console.WriteLine("");
                Console.WriteLine("Richtig!");
                Console.WriteLine("----------");
                Console.WriteLine("Alle Fragen richtig beantwortet!");
                Console.WriteLine("Gut gemacht!");
            }
            if (frage3.antwort3 == "nein" || frage3.antwort3 == "Nein" || frage3.antwort3 == "")
            {
                jaNein.ausgabe = false;
                Console.WriteLine("");
                Console.WriteLine("Falsch!");
                Console.WriteLine("");
            }
            if (jaNein.ausgabe == true)
            {
                Console.WriteLine("Nächste Frage:");
            }
            if (jaNein.ausgabe == false)
            {
                Console.WriteLine("Gib auf!");
            }
            #endregion


            Console.ReadKey();
        }
    }
}