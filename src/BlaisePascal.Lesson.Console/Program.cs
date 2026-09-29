using BlaisePascal.Lesson.Domain;
using System.Security.Cryptography.X509Certificates;
/// <summary>
/// 
/// </summary>
public class Program // Classe
{
    // Metodo Di Entrata Per Esecuzione Del Codice
    public static void Main()
    {
        Console.WriteLine("     Inserisci Il Nome Del Cliente         ");
        Console.WriteLine("");
        string NomeCliente = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine(" __________________________________________");
        Console.WriteLine("|                                          |");
        Console.WriteLine("|     BENVENUTO NELLA GESTIONE ORDINI      |");
        Console.WriteLine("|                                          |");
        Console.WriteLine("|__________________________________________|");
        Console.WriteLine("|                                          |");      
        Console.WriteLine("|     Inserisci Il Tipo Di Consegna        |");
        Console.WriteLine("|                                          |");
        Console.WriteLine("|__________________________________________|");
        Console.WriteLine("");
        string TipoConsegna = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("  Inserisci Il Numero Di Pacchi Comprati   ");
        Console.WriteLine("");
         int NumeroPacchiComprati = int.Parse(Console.ReadLine());

        const int CostoSpedizione = 10;
                          
            int CostoTotale = CostoSpedizione * NumeroPacchiComprati;

        Console.WriteLine($"Tipo Consegna: {TipoConsegna}");
        Console.WriteLine($"Costo Totale: {CostoTotale}");
        
        Class1 NuovaCLasse = new Class1();
    }
    
   
}