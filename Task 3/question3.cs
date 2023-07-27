using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class objpara
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public void display(objpara obj)
        {
            obj.id = id;
            obj.name = name;
            obj.age = age;
            Console.WriteLine("Details of employee");
            Console.WriteLine($" Name of the employee :{obj.name}");
            Console.WriteLine($" Employee age :{obj.age}");
            Console.WriteLine($" Employee id :{obj.id}");
        }
        static void Main(string[] args)
        {
            objpara obj = new objpara();
            Console.WriteLine("Enter no of employees");
            int count = Convert.ToInt32( Console.ReadLine() );

            for( int i = 0; i < count; i++ )
            {
               

                Console.WriteLine("Enter Employee Name ");
                obj.name = Console.ReadLine();
                Console.WriteLine("Enter employee id");
                obj.id = Convert.ToInt32( Console.ReadLine() );
                Console.WriteLine("Enter employee age");
                obj.age = Convert.ToInt32( Console.ReadLine() );
               
                obj.display(obj);
            }
            Console.ReadLine();
        }
    }
}
