using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=3,ModelYear=2016,DailyPrice=600,Description="Otomatik vites , Günlük km: 500 km/gün , Ehliyet yaşı: 2 ve üzeri" },
                new Car{Id=2,BrandId=4,ColorId=1,ModelYear=2010,DailyPrice=500,Description="Manuel vites , Günlük km: 500 km/gün , Ehliyet yaşı: 1 ve üzeri" },
                new Car{Id=3,BrandId=2,ColorId=1,ModelYear=2017,DailyPrice=700,Description="Otomatik vites , Günlük km: 500 km/gün , Ehliyet yaşı: 1 ve üzeri" },
                new Car{Id=4,BrandId=5,ColorId=2,ModelYear=2018,DailyPrice=750,Description="Otomatik vites , Günlük km: 500 km/gün , Ehliyet yaşı: 1 ve üzeri" },
                new Car{Id=5,BrandId=2,ColorId=3,ModelYear=2019,DailyPrice=800,Description="Manuel vites , Günlük km: 500 km/gün , Ehliyet yaşı: 1 ve üzeri" },
                new Car{Id=6,BrandId=3,ColorId=2,ModelYear=2020,DailyPrice=900,Description="Otomatik vites , Günlük km: 500 km/gün , Ehliyet yaşı: 2 ve üzeri" },
            };



        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            _cars.Add(car);

            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;  
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c=>c.Id==Id).ToList();// içindeki şarta uyan bütün elemanları yeni bir liste haline gitirir
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;
            
        }
    }
}
