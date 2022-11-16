using System;
using System.Collections;
using System.IO;
using System.Xml.Linq;

namespace TryCatchPractices
{
    class MyException : Exception
    {
        public MyException(string message = "myException") : base(message)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Exception> exceptions = new List<Exception>()
                {
                    new MyException(),
                    new ArgumentNullException(),
                    new  DriveNotFoundException(),
                    new FormatException(),
                    new  IndexOutOfRangeException()
                };
                foreach (Exception ex in exceptions)
                {
                    try
                    {
                        throw ex;
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}