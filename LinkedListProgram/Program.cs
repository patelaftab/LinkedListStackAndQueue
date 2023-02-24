﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter An Option\n" +
                    "Choose 1: For Creating Simple LinkedList\n"+
                    "Choose 2:For Adding First Element\n"+
                    "Choose 3:To Delete Fist Element\n"+
                    "Choose 4:To Delete Last Element\n"+
                    "Choose 5: To Stop Program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Display();   
                        break;
                    case 2:
                        linkedList.AddFirst(70);
                        linkedList.AddFirst(30);
                        linkedList.AddFirst(56);
                        linkedList.Display();
                        break;
                    case 3:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveFirst();
                        linkedList.Display();
                        break;
                    case 4:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveLast();
                        linkedList.Display();
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine();
                        break;

                }
            }
        }
    }
}
