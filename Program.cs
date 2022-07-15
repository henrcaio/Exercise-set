using System;
using Exercise_set.Entities;
using System.Collections.Generic;

namespace Exercise_set {
    class Program {
        static void Main(string[] args) {

            HashSet<Student> set = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int courseA = int.Parse(Console.ReadLine());
            for (int i = 0; i < courseA; i++) {
               int x = int.Parse(Console.ReadLine());
                set.Add(new Student(x));
            }

            Console.Write("How many students for course B? ");
            int courseB = int.Parse(Console.ReadLine());
            for (int i = 0; i < courseB; i++) {
                int x = int.Parse(Console.ReadLine());
                set.Add(new Student(x));
            }

            Console.Write("How many students for course C? ");
            int courseC = int.Parse(Console.ReadLine());
            for (int i = 0; i < courseC; i++) {
                int x = int.Parse(Console.ReadLine());
                set.Add(new Student(x));
            }


            Console.WriteLine("Total students: " + set.Count);
        }
    }
}
