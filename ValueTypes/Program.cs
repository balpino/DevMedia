using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    class Program
    {
        enum acessorio { Sapato, Bolsa, Cinto, Carteira, Colar }

        static void Main(string[] args)
        {
            int i = 10;
            string a = "ok";

            float ff = 10.89f;
            double dd = 90.9876;

            decimal dec = 10.88m;

            bool bl = true;

            int Item = (int)acessorio.Cinto;

            //implicit conversion
            int i1 = 10;
            long i2 = i1;

            //explicit conversion
            double d1 = 10.9;
            int d2 = (int)d1;

            //int.Parse
            //int.TryParse
            //Convert

            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
