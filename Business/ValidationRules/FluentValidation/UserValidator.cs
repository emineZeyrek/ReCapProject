using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<Users>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserId).NotEmpty();
            RuleFor(u=>u.FirstName).NotEmpty();
        }
    }
}
