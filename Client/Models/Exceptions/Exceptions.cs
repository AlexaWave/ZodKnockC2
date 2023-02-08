using System;

namespace Client.Models
{
    public class ZodException : Exception
    {
        
        public ZodException(string message) : base(message) { }
        public ZodException(string message, Exception inner) : base(message, inner) { }

    }
}
