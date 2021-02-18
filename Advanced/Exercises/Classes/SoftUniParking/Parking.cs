using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    class Parking
    {
        private List<Car> cars;

        private int capasity;

        public Parking(int capasity)
        {
            this.capasity = capasity;
            cars = new List<Car>();

        }

        public int Count 
        { 
            get 
            {
                return this.cars.Count;
            } 
        }

        public string AddCar(Car car)
        {
            if (this.cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if (this.cars.Count == this.capasity)
            {
                return "Parking is full!";
            }

            this.cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string regNum)
        {
            Car car = this.cars.FirstOrDefault(c => c.RegistrationNumber == regNum);

            if (car == null)
            {
                return "Car with that registration number, doesn't exist!";
            }

            this.cars.Remove(car);
            return $"Successfully removed {regNum}";
        }

        public Car GetCar(string regNum)
        {
            Car car = this.cars.FirstOrDefault(c => c.RegistrationNumber == regNum);
            return car;
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            this.cars = this.cars.Where(c => !registrationNumbers.Contains(c.RegistrationNumber)).ToList();


        }

    }
}
