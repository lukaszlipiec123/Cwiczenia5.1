using System;
using System.Collections.Generic;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = LinqTasks.Task1();
            var t2 = LinqTasks.Task2();
            var t3 = LinqTasks.Task3();
            var t4 = LinqTasks.Task4();
            var t5 = LinqTasks.Task5();
            var t6 = LinqTasks.Task6();
            var t7 = LinqTasks.Task7();
            var t8 = LinqTasks.Task8();
            var t9 = LinqTasks.Task9();
            var t10 = LinqTasks.Task10();
            var t11 = LinqTasks.Task11();
            var t12 = LinqTasks.Task12();
            var t13 = LinqTasks.Task13(new int[] { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 });
            var t14 = LinqTasks.Task14();
            //printEnumerable(t1);
            //printEnumerable(t2);
            //Console.WriteLine(t3);
            //printEnumerable(t4);
            //printEnumerable(t5);
            //printEnumerable(t6);
            //printEnumerable(t7);
            //Console.WriteLine(t8);
            //Console.WriteLine(t9);
            //printEnumerable(t10);
            //printEnumerable(t11);
            //printEnumerable(t12);
            //Console.WriteLine(t13);
            printEnumerable(t14);
        }

        static void printEnumerable(IEnumerable<Object> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
