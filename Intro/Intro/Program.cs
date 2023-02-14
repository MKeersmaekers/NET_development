using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Maak een variabele 'cursus' aan met de tekst WPF 
            string cursus = "WPF";

            // Toon deze via de WriteLine methode van de Trace klasse

            Trace.WriteLine("Oef 1: " + cursus);
            Trace.WriteLine($"Oef 1: {cursus}");

            //2. Maak een constante variabele 'loon' aan met als inhoud het geheel getal 2000 

            const int loon = 2000;

            // Toon deze via de WriteLine methode van de Trace klasse

            Trace.WriteLine("Oef 2: " + loon);

            //3. Maak een variabele 'pi' aan met als inhoud het decimaal getal 3.14 

            double pi = 3.14;

            // Toon deze via de WriteLine methode van de Trace klasse

            Trace.WriteLine("Oef 3: " + pi);

            //4a. Maak een boolean variabele 'isGeslaagd' die standaard true is
            //4b. Schrijf code om te controleren dat als 'isGeslaagd' true is, we de boodschap 'Geslaagd' naar de Output schrijven
            //4c. Als 'isGeslaagd' false is, dan tonen we de boodschap 'Niet geslaagd'

            bool isGeslaagd = true;
            if (isGeslaagd)
            {
                Trace.WriteLine("Geslaagd");
            } else
            {
                Trace.WriteLine("Niet geslaagd");
            }

            //5a. Maak een variabele 'resultaat' aan met geheel getal 8
            //5b. Kleiner dan 8 = 'Gefaald'
            //5c. Groter of gelijk aan 8 en kleiner dan 10 = 'Tolereerbaar'
            //5d. Groter of gelijk aan 10 = 'Geslaagd'

            int resultaat = 8;
            if (resultaat < 8)
            {
                Trace.WriteLine("Gefaald");
            } else if (resultaat >= 8 & resultaat < 10) {
                Trace.WriteLine("Tolereerbaar");
            } else
            {
                Trace.WriteLine("Geslaagd");
            }
            //6a. Maak variabele kleur aan met inhoud 'Groen'
            //6b. Indien groen: doorrijden
            //6c. Indien oranje: opletten
            //6d. Anders: stoppen

            string kleur = "Groen";

            switch (kleur)
            {
                case "Groen":
                    Trace.WriteLine("Doorrijden");
                    break;
                case "Oranje":
                    Trace.WriteLine("Opletten");
                    break;
                default:
                    Trace.WriteLine("Stoppen");
                    break;
            }

            List<int> getallen = new List<int>() { 0, 1, 2, 3, 4, 5 };            
            //7 Loop over deze getallen met een gewone for loop

            for (int i = 0; i< getallen.Count; i++)
            {
                Trace.WriteLine(getallen[i]);
            }

            //8 Loop over deze getallen met een foreach loop

            foreach (int getal in getallen)
            {
                Trace.WriteLine(getal);
            }

            //9 Loop over de eerste 3 getallen van deze lijst met behulp van een do while loop
            int counter = 0;
            do
            {
                Trace.WriteLine(getallen[counter]);
                counter++;
            } while (counter < 3);

            //10a. Maak een nieuwe klasse 'Movie' aan
            //10b. Deze klasse moet 2 properties hebben: titel = tekst, jaar = geheel getal
            //TIP: gebruik prop + tab + tab voor snelle notatie

            //10c: Voeg een derde property aantalOscars toe = geheel getal. 
            //!!! Deze MOET je volledig schrijven = private variabele + public property met getter en setter

            //11a. Maak een object aan van deze klasse
            //11b. Geef titel en jaar een waarde

            Movie myMovie = new Movie();

            //12a. Voeg een constructor toe aan de klasse 'Movie' met parameters voor de titel en het jaar - TIP: ctor + tab + tab
            //12b. Maak een nieuw object van deze klasse aan via deze constructor
            //12c. Zorg ervoor dat stap 11a. (lege constructor) blijft werken!

            //13a. Encapsulation: zorg ervoor dat het aantal oscars niet lager dan 0 kan zijn. Lager dan 0 wordt default 0
            //13b. Test hier uit!

            myMovie.AantalOscars = 6;

            //14a. Maak een private variable aan voor de regisseur van de film
            //14b. Kunnen we deze variabele hier een waarde geven? Test uit

            //15a. Maak een internal variable aan voor de rating van de film (getal van 0 t.e.m. 5)
            //15b. Kunnen we deze variabele hier een waarde geven? Test uit

            //16a. Schrijf een methode in de Movie class die de titel toont in onze Output (Trace.WriteLine())
            //16b. Voer deze methode hier uit

            //17a. Maak deze methode private, werkt dit nog?
            //17b. Maak deze methode protected, werkt dit?
            //17c. Maak deze methode internal, werkt dit?

            //18a. Maak een klasse Vorm aan met property oppervlakte = geheel getal
            //18b. Maak een methode OutputOppervlakte aan die de oppervlakte naar de Output wegschrijft
            //18c. Maak een klasse Cirkel aan die overerft van de klasse Vorm
            //18d. Maak hier een object van de klasse Cirkel aan
            //18e. Zet de oppervlakte op 50
            //18f. Voer de OutputOppervlakte methode uit

            //19a. Maak een klasse Dier
            //19b. Maak een overschrijfbare methode MaakGeluid aan die 'Miaauw' naar de Output wegschrijft
            //19c. Maak een klasse Hond aan die overerft van de klasse Dier
            //19d. Maak hier een object van de klasse Hond aan
            //19e. Voer de MaakGeluid methode uit: wat verwacht je?

            //19f. Overschrijf de MaakGeluid methode zodat je 'Woef' naar de Output wegschrijft
            //19g. Voer de MaakGeluid methode nog eens uit

        }
    }
}
