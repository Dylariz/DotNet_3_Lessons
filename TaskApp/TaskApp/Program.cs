using System;
using System.Threading.Tasks;

namespace TaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t1 = new Task<int>(() => {
                int a = 0;
                for (int i = 1; i <= 100; i++)
                {
                    a = a + i;
                }
                return a;
            });
            t1.Start();
            Console.WriteLine(t1.Result);
            Console.ReadLine();
        }
    }
}
