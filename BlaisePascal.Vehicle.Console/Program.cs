using System;   
using System.Text;
using BlaisePascal.VehicleClass.Domain;
using BlaisePascal.VehicleClass.UiConsole;





namespace BlaisePascal.VehicleClass.UiConsole
{
    public class Program
    {
        public static void Main()
        {
            Vehicle vehicle = new Vehicle();
            string licence = vehicle.GetLicencePlate();

            Console.WriteLine($"Vehicle Licence Plate: {licence}");
        }
    }
}


