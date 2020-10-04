using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    class Program
    {

        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.RemoveAt(2);
            Console.WriteLine(list.IndexOf(3));

            list.Insert(5, 2);
            Print(list);
        }
        static void Print(MyList<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
