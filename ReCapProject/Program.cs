using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ReCapProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
            }

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.ModelYear);
            //}
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarName);
            //}

            foreach (var car in carManager.GetCarsByBrandId(2))
            {

                Console.WriteLine(car.CarName);
            }

            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.CarName);
            }



        }
    }
}