using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilies.Results
{
    //temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; } //get sadece okunabilir demek. Ekleme işlemi başarılı mı değil mi? 
        string Message { get; } // Kullanıcı bilgilendirme.
    }
}
