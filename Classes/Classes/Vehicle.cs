using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycles, Spaceships, Planes, Boats}
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public bool IsRunning { get; private set; }
        public Indicator LeftIndicator { get; set; }
        public Indicator RightIndicator { get; set; }

        // ctor creates the constructor
        public Vehicle(string make, string model, double mileage, VehicleType typeOfVehicle)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = typeOfVehicle;
        }

        public Vehicle()
        {

        }

        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You turned the vehicle on");
        }
        public void TurnOff()
        {
            Console.WriteLine("You turn off the vehicle");
            IsRunning = false;
        }

        public int MyProperty { get; set; }
        public void IndecateLeft()
        {
            LeftIndicator.TurnOn();
            RightIndicator.TurnOff();
        }

        public void IndecateRight()
        {
            LeftIndicator.TurnOn();
            RightIndicator.TurnOff();
        }

        public void TurnOnHazards()
        {
            LeftIndicator.TurnOn();
            RightIndicator.TurnOff();
        }
        public void ClearIndicators()
        {
            LeftIndicator.TurnOn();
            RightIndicator.TurnOff();
        }

        public class Indicator
        {
            public bool IsFlashing { get; private set; }
            public void TurnOn()
            {
                IsFlashing = true;
            }

            public void TurnOff()
            {
                IsFlashing = false;

            }
        }
    }
}
