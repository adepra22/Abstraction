using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Persegi : BangunDatar
    {
        public int x;

        public override void Luas()
        {
            Console.Write("Masukkan nilai sisi       = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luas Persegi              = " + (x * x));
        }

        public override void Keliling()
        {
            Console.WriteLine("Keliling Persegi          = " + (4 * x));
        }
    }
}
