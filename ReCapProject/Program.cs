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
            CarManager carManager = CarTest();
            BrandTest();

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

            var result = brandManager.GetAll();

            if (result.Success==true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

           

        }

        private static CarManager CarTest()
        {
            CarManager carManager = new CarManager(new EFCarDal());

            var result = carManager.GetCarDetalis();

            if (result.Success== true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            return carManager;
        }
    }
}