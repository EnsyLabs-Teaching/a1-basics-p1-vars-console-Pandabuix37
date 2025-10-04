namespace Assignment1;

internal static class Assignment
{
    public static void AssignmentMain()
    {
        /*
         
Cerinte:
Creare variabile
a. Creaza o variabila de tip int numita 'numarIntreg' si initializeaz-o cu valoarea 10.
b. Creaza o variabila de tip float numita 'numarFloat' si initializeaz-o cu valoarea 20.5231.
c. Creaza o variabila de tip string numita 'text' si initializeaz-o cu valoarea "Salut, lume!".
d. Creaza o variabila de tip bool numita 'esteAdevarat' si initializeaz-o cu valoarea true.
Afisare variabile
a. Afiseaza valoarea fiecarei variabile folosind Console.WriteLine.
Program, Creaza un program care face urmatoarele
a. Afiseaza in consola: "Salut, lume! Astazi invat C#."
b. Afiseaza in consola: "Care este numele tau?"
c. Citeste numele utilizatorului de la tastatura si stocheaza-l intr-o variabila numita 'nume'.
d. Afiseaza in consola: "Bine ai venit, [nume]!", unde [nume] este valoarea citita de la utilizator.
e. Afiseaza in consola: "Introdu un numar intreg:"
f. Citeste numarul intreg de la tastatura si stocheaza-l intr-o variabila numita 'numarIntregCitit'.
g. Afiseaza in consola: "Ai introdus numarul: [numarIntregCitit]", unde [numarIntregCitit] este valoarea citita de la utilizator.
h. Afiseaza in consola: "Utilizatorul [nume] a introdus numarul [numarIntregCitit].", unde [nume] si [numarIntregCitit] sunt valorile citite de la utilizator.
*/



        // Your code here
      
        int numarIntreg = 10;
        float numarFloat = 20.5231f;
        string text = "Salut, lume";
        bool esteAdevarat = true;
        Console.WriteLine(numarIntreg);
        Console.WriteLine(numarFloat);
        Console.WriteLine(text);
        Console.WriteLine(esteAdevarat);
        Console.WriteLine();
        Console.WriteLine("Salut lume, astazi invat C#.");
        Console.WriteLine();
        Console.WriteLine("Care este numele tau?");
        string nume=Console.ReadLine();
        Console.WriteLine("Bine ai venit" + " " + nume + "!" );
        Console.WriteLine();
        Console.WriteLine("Introdu un numar intreg:");
        string numarIntregCitit = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Utilizatorul" + " " + nume + " a introdus numarul" + " " + numarIntregCitit);
    }
}
