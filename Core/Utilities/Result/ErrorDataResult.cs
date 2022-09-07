using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public class ErorrDataResult<T> : DataResult<T>
    {
        public ErorrDataResult(T data, string message) : base(data, false, message)
        {

        }
        public ErorrDataResult(T data) : base(data, false)
        {

        }
        public ErorrDataResult(string message) : base(default, false, message)
        {

        }
        public ErorrDataResult() : base(default, false)
        {

        }
    }
}
