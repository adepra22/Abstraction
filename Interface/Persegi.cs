using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Persegi : IBangunDatar
    {
        public int x;

        public void Luas()
        {
            Console.Write("Masukkan nilai sisi       = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luas Persegi              = " + (x * x));
        }

        public void Keliling()
        {
            Console.WriteLine("Keliling Persegi          = " + (4 * x));
        }
    }
}
