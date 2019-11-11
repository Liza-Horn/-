using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
    
                Console.WriteLine("r = ");
            int r = Convert.ToInt32(Console.ReadLine());
            if (r < 20)
                Console.WriteLine("Неудолитворяет условие");
            else Console.WriteLine((Math.PI * r * r) - (Math.PI * 20 * 20));


            Console.ReadKey();

           
        }
    }
}
