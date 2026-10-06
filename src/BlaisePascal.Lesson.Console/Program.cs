using BlaisePascal.Lesson.Domain;
using System.Security.Cryptography.X509Certificates;
/// <summary>
/// 
/// </summary>
public class Program//classe
{ 
    // Metodo Di Entrata Per Esecuzione Del Codice
    public static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
        

        Enemy enemy1 = new Enemy();
        enemy1.setHealth(10);
        Console.WriteLine($"Enemy 1 Health: {enemy1.Health}");



    }


}