using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilies.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)//bu sefer this değil base dedik. Base dediğimiz Result oluyor
        {

        }
        public SuccessResult() : base(true)
        {

        }

    }
}
