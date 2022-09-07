using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {

        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rentals rentals)
        {
            if (rentals.ReturnDate != default(DateTime))
            {
                _rentalDal.Add(rentals);

                return new SuccessResult(Messages.RentalAdded);
            }

            return new ErrorResult("Araba Teslim Edilmedi");
        }

        public IResult Delete(Rentals rentals)
        {
            _rentalDal.Delete(rentals);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_rentalDal.GetAll());
        }

        public IDataResult<Rentals> GetById(int RentalId)
        {
            return new SuccessDataResult<Rentals>(_rentalDal.Get(r => r.RentalId == RentalId));
        }

        public IResult Update(Rentals rentals)
        {
            _rentalDal.Update(rentals);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
