using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // ExcepitonIntro();

            Console.ReadLine();
        }

        private static void ExcepitonIntro()
        {
            try
            {
                string[] students = new string[3] { "Veysel", "Vedat", "Samet" };

                students[3] = "Ezgi";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);//InnerException
                throw;
            }
        }
    }
}
