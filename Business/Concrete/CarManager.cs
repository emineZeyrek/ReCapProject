using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        public IDataResult<List<Car>> GetAll()
        {
            //iş kodları

            if (DateTime.Now.Hour == 14)
            {
                return new ErorrDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);// SuccesDataResult içindeki Car nesnesine bu mesajı gönder
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int Id)
        {
            return new SuccessDataResult<List<Car>> (_carDal.GetAll(c => c.BrandId == Id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == Id)) ;
        }

        public IDataResult<List<CarDetailDto>> GetCarDetalis()
        {
            if(DateTime.Now.Hour == 22)
            {
                return new ErorrDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<Car> GetById(int Id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c =>c.CarId == Id));
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {

            //business codes 
            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.ColorDeleted);

        }

     
    }
}
