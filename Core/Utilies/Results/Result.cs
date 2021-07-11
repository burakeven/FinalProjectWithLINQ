using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilies.Results
{
    public class Result : IResult
    {
        

        public Result(bool success, string message):this(success) //this demek kendi anlamına geliyor. This'in parantez içinde tek parametre verdiğimiz için
            //Result'un diğer tek parametreli constructor'unu da çalıştırır.
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
