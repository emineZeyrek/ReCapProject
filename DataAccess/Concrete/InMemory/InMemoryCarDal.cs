using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{Id=1,CarName="Opel Astra Benzinli Otomatik",BrandId=1,ColorId=3,ModelYear=2016,DailyPrice=600,Description="Otomatik vites , Günlük km: 500 km/gün , Ehliyet yaşı: 2 ve üzeri" },
                new Car{Id=2,CarName="Toyota Corolla Dizel Manuel", BrandId=4,ColorId=1,ModelYear=2010,DailyPrice=500,Description="Manuel vites , Günlük km: 500 km/gün , Ehliyet yaşı: 1 ve üzeri" },
                new Car{Id=3,CarName="Renault Megane Benzinli Otomatik",BrandId=2,ColorId=1,ModelYear=2017,DailyPrice=700,Description="Otomatik vites , Günlük km: 500 km/gün , Ehliyet yaşı: 1 ve üzeri" },
                new Car{Id=4,CarName="Hyundai Elantra Benzinli Otomatik",BrandId=5,ColorId=2,ModelYear=2018,DailyPrice=750,Description="Otomatik vites , Günlük km: 500 km/gün , Ehliyet yaşı: 1 ve üzeri" },
                new Car{Id=5,CarName="Renault Fluence Dizel Manuel",BrandId=2,ColorId=3,ModelYear=2019,DailyPrice=800,Description="Manuel vites , Günlük km: 500 km/gün , Ehliyet yaşı: 1 ve üzeri" },
                new Car{Id=6,CarName="Skoda Fabia Benzinli Otomatik",BrandId=3,ColorId=2,ModelYear=2020,DailyPrice=900,Description="Otomatik vites , Günlük km: 500 km/gün , Ehliyet yaşı: 2 ve üzeri" },
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

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;  
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c=>c.Id==Id).ToList();// içindeki şarta uyan bütün elemanları yeni bir liste haline gitirir
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;
            
        }
    }
}
