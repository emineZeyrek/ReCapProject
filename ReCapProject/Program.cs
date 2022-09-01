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
            //CarManager carManager = CarTest();
            //BrandTest();

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.ModelYear);
            //}
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarName);
            //}

            //foreach (var car in carManager.GetCarsByBrandId(2))
            //{

            //    Console.WriteLine(car.CarName);
            //}

            //foreach (var car in carManager.GetCarsByColorId(1))
            //{
            //    Console.WriteLine(car.CarName);
            //}

           

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static CarManager CarTest()
        {
            CarManager carManager = new CarManager(new EFCarDal());

            foreach (var car in carManager.GetCarDetalis())
            {
                Console.WriteLine(car.CarName+ "/" +car.BrandName);
            }

            return carManager;
        }
    }
}