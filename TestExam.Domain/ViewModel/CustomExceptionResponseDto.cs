using System;
using System.Collections.Generic;
using System.Text;

namespace TestExam.Domain.ViewModel
{
    public class CustomExceptionResponseDto
    {
        public int MessageCode { get; set; }
        public string Message { get; set; }
        public object OptionalData { get; set; }
    }
}
