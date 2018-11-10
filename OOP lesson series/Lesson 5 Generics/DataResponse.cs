using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lesson_series.Lesson_5_Generics
{
    public class DataResponse<T>
    {
        public string Error { set; get; }
        public bool IsSuccess => string.IsNullOrEmpty(Error);
        public T Data { set; get; }

        public DataResponse(T data)
        {
            Data = data;
        }

        public DataResponse(T data, string error)
        {
            Data = data;
            Error = error;
        }

        public override string ToString()
        {
            if (IsSuccess)
            {
                return $"Successfull response!\r\nData transfered:{Data}";
            }
            return $"Failed response!\r\nData not transfered:{Data}"; ;
        }

    }
}



