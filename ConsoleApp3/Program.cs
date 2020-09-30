using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        

        static void Main()
        {
            

            
            
            var l = from n in Student.Creator
                    where n == Index.()                           
                    select n;
            Console.WriteLine(l.Count());
            
            
            
        }
        public class Student
        {
            public String Name { get; set; }
            public String Group { get; set; }
            UInt16 Age { get; set; }
            public Student(String NameC, String GroupC, UInt16 AgeC)
            {
                Name = NameC;
                Group = GroupC;
                Age = AgeC;
            }
            public static Student[] Creator => new Student[] 
            { 
                new Student("Maxim Milik", "group4", 16),
                new Student("Roman Pozho", "group3", 15 )
            }; 
        }

    }
}
