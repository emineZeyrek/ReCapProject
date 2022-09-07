using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    // Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; }// true - false
        string Message { get; } // bilgilendirme, yönlendirme
    }
}

