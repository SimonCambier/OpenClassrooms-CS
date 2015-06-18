using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClassroomsTableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jours = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            Array.Sort(jours);
            for (int i = 0; i < jours.Length; i++)
            {
                Console.WriteLine(jours[i]);
            }
            Console.ReadKey();
        }
    }
}
