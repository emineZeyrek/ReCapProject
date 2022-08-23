using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ReCapProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
            }

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear);
            }

        }
    }
}