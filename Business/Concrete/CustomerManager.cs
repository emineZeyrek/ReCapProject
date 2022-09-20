using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomersService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal=customerDal;
        }

        public IResult Add(Customers customers)
        {
            _customerDal.Add(customers);

            return new SuccessResult(Messages.CustomersAdded);
        }

        public IResult Delete(Customers customers)
        {
            _customerDal.Delete(customers);

            return new SuccessResult(Messages.CustomersDeleted);
        }

       

        public IDataResult<List<Customers>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErorrDataResult<List<Customers>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Customers>>(_customerDal.GetAll(), Messages.CustomersListed);
        }   

        public IDataResult<Customers> GetById(int CustomerId)
        {
            return new SuccessDataResult<Customers>(_customerDal.Get(c=>c.UserId == CustomerId ));
        }

        public IResult Update(Customers customers)
        {
            _customerDal.Update(customers);

            return new SuccessResult(Messages.CustomersUpdated);
        }
    }
}
