using System;
namespace my_log_app_test.Models
{
    public class Log
    {
        public string Message { get; set; }

        public Log(string message)
        {
            this.Message = message;
        }
    }
}

