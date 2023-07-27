using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class question2
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(null);
            arrayList.Add("yamini");
            arrayList.Add(20);
           
           int count = arrayList.Count;
            foreach (var a in arrayList)
            {

                Console.WriteLine(a);
                if (a == null)
                {
                    Console.WriteLine("i have a value");
                }
            }
            Console.ReadLine();
           
            
        }
    }
}
