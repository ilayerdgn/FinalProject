using System;
namespace Core.Utilities.Results
{
    public class Result:IResult
    {
       

        public Result(bool success, string message):this(success)//bu this kendini ifade ediyor yani kendi içerisindeki diğer constructorı da çalıştırıyor
        {
            Message = message;
          
        }

        public Result(bool success)
        {
            
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }//getter read onlydir constructor dışında set edilmez
    }
}
