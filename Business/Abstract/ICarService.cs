using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll(); // aynı zamanda işlem sonucu ve mesajı döndürür

        IDataResult<List<Car>> GetCarsByBrandId(int Id);
        IDataResult<List<Car>> GetCarsByColorId(int Id);

        IDataResult<List<CarDetailDto>>GetCarDetalis();
        IResult Add(Car car);
        IDataResult<Car> GetById(int Id); 
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
