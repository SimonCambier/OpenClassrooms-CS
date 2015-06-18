using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_c_est_le_week_end
{
    class Program
    {
        static void Main(string[] args)
        {
            string aun = MsgToUser1();
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday || DateTime.Now.DayOfWeek == DayOfWeek.Tuesday || DateTime.Now.DayOfWeek == DayOfWeek.Wednesday || DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            {
                if (DateTime.Now.Hour >= 9 && DateTime.Now.Hour <= 18)
                {
                    Console.WriteLine("Bonjour " + aun + ".");
                }
                else
                {
                    Console.WriteLine("Bonsoir " + aun + ".");
                }
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour >= 9 && DateTime.Now.Hour <= 18)
            {
                Console.WriteLine("Bonjour " + aun + ".");
            }
            else
            {
                Console.WriteLine("Bon week-end " + aun + ".");
            }
            Console.ReadKey();
        }       
        static string MsgToUser1()
        {
            string aun = Environment.UserName;
            return aun;
        }
    }
}
