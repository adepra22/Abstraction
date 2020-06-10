using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Segitiga : IBangunDatar
    {
        public int s = 0;
        public float a, t;

        public void Luas()
        {
            Console.Write("Masukkan nilai alas       = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai tinggi     = ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai sisi       = ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luas Segitiga             = " + ((a * t) / 2));
        }

        public void Keliling()
        {
            Console.WriteLine("Keliling Segitiga         = " + (s + s + s));
        }
    }
}
