using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.VehicleClass.Domain
{
    public class Vehicle
    {
        private string _licensePlate; //targa del veicolo
        private int _kilometers; //chilometraggio del veicolo
        private double _dailyRate; //costo del noleggio giornaliero non puo essere statica perché ogni veicolo ha un costo di noleggio giornaliero diverso
                                   // potrebbe essere statico il maxfuelLevel perché è uguale per tutti i veicoli, che e 100%
        private double _fuelLevel; //livello di carburante del veicolo

        public string LicensePlate
        {
            get
            {
                return _licensePlate;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length != 7)
                {
                    throw new ArgumentException($"value is not allowed {nameof(_licensePlate)}: {value} ");

                }
                else
                {
                    _licensePlate = value;
                }
            }
        }
        public string LicencePlate { get; private set; } //il get è pubblico, il set è privato
        public int Kilometers { 
            get { return _kilometers; }
            private set { if(value < 0) throw new ArgumentException("Kilometers cannot be negative.");          

                _kilometers = value;
            }
        }
        public double DailyRate { get; private set; }
        public double FuelLevel { get; private set; }

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