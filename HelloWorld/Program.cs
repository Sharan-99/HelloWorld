using System;
using System.Collections;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();

            Student s1 = new Student(1, "Sharan", 99);
            Student s2 = new Student(2, "Aravindhan", 98);
            Student s3 = new Student(3, "Gokul", 97);
            Student s4 = new Student(4, "Kawin", 90);

            h.Add(s1.Id, s1);
            h.Add(s2.Id, s2);
            h.Add(s3.Id, s3);
            h.Add(s4.Id, s4);

            Student s = (Student)h[s1.Id];

            Console.WriteLine("Stud-Id:{0}, Name:{1}, GPA:{2}", s.Id, s.Name, s.GPA);

            foreach(Student i in h.Values)
            {
                Console.WriteLine("Stud-Id:"+i.Id);
                Console.WriteLine("Name:" + i.Name);
                Console.WriteLine("GPA:" + i.GPA);

            }


        }
    }
}
