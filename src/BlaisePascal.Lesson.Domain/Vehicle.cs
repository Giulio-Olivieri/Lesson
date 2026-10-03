using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.VehicleClass.Domain
{
    public class Vehicle
    {
        private string _licencePlate;
        private int _kilometers;
        private double _dailyRate;
        private double _fuelLevel;

        public string LicencePlate { get; private set; } //il get è pubblico, il set è privato
        public int Kilometers { 
            get { return _kilometers; }
            private set { if(value < 0) throw new ArgumentException("Kilometers cannot be negative."); _kilometers = value;

                _kilometers = value;
            }
        }
        public double DailyRate { get; private set; }
        public double FuelLevel { get; private set; }


        public string GetLicencePlate()
        {
            return _licencePlate;
        }

        // Costruttore della classe Vehicle
        public Vehicle(string licencePlate)
        {
            LicencePlate = licencePlate; //chiamata al private set
        }

        public Vehicle(string licencePlate, int kilometers, double dailyRate)
        {

        }
    }
} 