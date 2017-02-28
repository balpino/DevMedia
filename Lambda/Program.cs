using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{

    class Program
    {
        delegate int Divide(int a, int b);
        static void Main(string[] args)
        {
            Divide d = (x,y) => x / y;
            //Console.WriteLine(d(10, 5));

            IEnumerable<string> itens = new List<string>(){ "tenis", "sapato", "meia", "chuteira", "meia" };

            List<string> result = itens.Where(i => i == "sapato").ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s.ToString());
            }
            
            Console.ReadKey();
        }
    }
}
