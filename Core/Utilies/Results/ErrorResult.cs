using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilies.Results
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message) : base(false, message)//bu sefer this değil base dedik. Base dediğimiz Result oluyor
        {

        }
        public ErrorResult() : base(false)
        {

        }
    }
}
