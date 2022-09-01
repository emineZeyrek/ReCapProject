using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal=carDal;
        }

        public List<Car> GetAll()
        {
            //iş kodları
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(c=>c.BrandId== Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(c => c.ColorId == Id);
        }

        public void Add(Car car)
        {
            if (car.CarName is { Length: >= 2 } && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
        }

        public List<CarDetailDto> GetCarDetalis()
        {
            return _carDal.GetCarDetails();
        }
    }
}
