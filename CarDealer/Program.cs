using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Id = 2;
            car.Make = "Ford";
            car.Model = "Focus";
            car.Year = DateTime.Now;

            Car superCar = new SuperCar();

            superCar.Id = 1;
            superCar.Make = "Ford";
            superCar.Model = "Focus";
            superCar.Year = DateTime.Now;
            ((SuperCar)superCar).MaxSpeed = 140;
            ((SuperCar)superCar).Automatic = true;

            SuperCar sportsCar = ((SuperCar)superCar);

            sportsCar.Turbo = true;
        }
    }
}
