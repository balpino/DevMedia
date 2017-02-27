using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[3];
            a1[0] = 10;
            a1[1] = 20;
            a1[2] = 30;

            bool[] a2 = new bool[] { true, false, true };

            string[] a3 = new string[] { "one", "two", "three" };

            int[,] b = new int[3, 3];
            b[0, 0] = 1;

            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("ok");
            al.Add(true);
        }
    }
}
