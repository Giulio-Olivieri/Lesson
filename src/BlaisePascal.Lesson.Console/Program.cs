using System.Security.Cryptography.X509Certificates;

public class Program // Classe
{
    // Metodo Di Entrata Per Esecuzione Del Codice
    public static void Main()
    {
        Console.WriteLine("Hello World");
        int CostoSpedizione = 5;
        CostoSpedizione = 10;

        int NumeroPacchiComprati = 2;

        string TipoConsegna = "Standard";

        int CostoTotale = CostoSpedizione * NumeroPacchiComprati;

        Console.WriteLine($"Tipo Consegna: {TipoConsegna}");
        Console.WriteLine($"Costo Totale: {CostoTotale}");

    }
    
   
}