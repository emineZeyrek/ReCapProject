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
    public class UserManager : IUsersService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(Users users)
        {
            _userDal.Add(users);

            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(Users users)
        {
            _userDal.Delete(users);

            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<Users>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErorrDataResult<List<Users>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Users>>(_userDal.GetAll(), Messages.CustomersListed);
        }

        public IDataResult<Users> GetById(int UserId)
        {
            return new SuccessDataResult<Users>(_userDal.Get(u => u.UserId ==UserId));
        }

        public IResult Update(Users users)
        {
            _userDal.Update(users);

            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
