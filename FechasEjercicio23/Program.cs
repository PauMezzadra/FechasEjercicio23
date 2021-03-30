using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechasEjercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha;
            Console.WriteLine("Ingrese una fecha con el formato dia/mes/año");
            if (!DateTime.TryParse(Console.ReadLine(), out fecha))
            {
                Console.WriteLine("Eso no es una fecha");
            }
            else
            {
                Console.WriteLine($"La fecha ingresada es {fecha}");
            }
            
            Console.ReadKey();
        }
    }
}
