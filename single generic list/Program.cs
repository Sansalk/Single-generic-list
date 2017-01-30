﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_generic_list
{
    class Program
    {
        static void Main(string[] args)
        {

            List<List<object>> list = new List<List<object>>();

            List<object> list1 = new List<object>();
            list1.Add(101);
            list1.Add(102);
            list1.Add(103);

            list.Add(list1);

            List<object> list2 = new List<object>();
            list2.Add("Test1");
            list2.Add("Test2");
            list2.Add("Test3");

            list.Add(list2);

            foreach (List<object> objectList in list)
            {
                foreach (object obj in objectList)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }

    }
}
