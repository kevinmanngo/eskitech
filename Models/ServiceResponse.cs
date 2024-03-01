using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eskitech.Models
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Meddelande { get; set; } = string.Empty;
    }
}