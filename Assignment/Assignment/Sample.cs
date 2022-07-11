using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Sample:InterfaceConcept
    {
        //1.Write a c# program to count the even and odd numbers in the following list.
        public void countEven()
        {
            int countEven = 0;
            int countOdd = 0;
            List<int> list = new List<int>();
            list.Add(50);
            list.Add(65);
            list.Add(56);
            list.Add(71);
            list.Add(81);
            foreach (int i in list)
            {
                if(i%2==0)
                    countEven++;
                else
                    countOdd++;
            }
            Console.WriteLine("count of even numbers:"+countEven);
            Console.WriteLine("count of odd numbers:" + countOdd);
        }

        //2.Explain Boxing and Unboxing using code snippets.
        public void boxing()
        {
            string name = "Vinay";
            object obj = 101;
            object obj1 = name;
            int value = (int)obj;
            string name1 = (string)obj1;
            Console.WriteLine("Boxing value:" + obj1);
            Console.WriteLine("Unboxing value:" + value);
            Console.WriteLine("Unboxing value:" + name1);
        }
        

        //3.Write a program to find the largest value out of 325, 750, 478.
        public void largestNumber()
        {
            int a, b, c;
            a = 325;
            b = 750;
            c = 478;
            if (a > b && a > c)
            {
                Console.WriteLine("a is big" + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("b is big" + b);
            }
            else 
            {
                Console.WriteLine("c is big" + c);
            }
        }

        //4.Write a program to prints all odd numbers between 1 and 10.
        public void oddNumbers()
        {
            int a = 10;
            for (int i = 0; i <= a; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("odd numbers between 1 to 10 is:");
                    Console.Write("\t"+i);
                }
            }
        }
        //6. Program to create an array list for Delhi, Mumbai, Kolkata, Chennai and sort them
        public void sortingCityNames()
        {
            ArrayList abc = new ArrayList();
            abc.Add("Delhi");
            abc.Add("Mumbai");
            abc.Add("Kolkata");
            abc.Add("Chennai");
            foreach (var item in abc)
            {
                Console.WriteLine("before sorting" + item);
            }
            abc.Sort();
            Console.WriteLine();
            foreach (var values in abc)
            {
                Console.WriteLine("After sorting" + values);
            }
        }
        //9. Write a program to display all the 11 cricket players using Generic Dictionary.
        public void cricketTeam()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Dhoni");
            dict.Add(2, "YuvaRaj Singh");
            dict.Add(3, "Virat Kohli");
            dict.Add(4, "Umesh Yadav");
            dict.Add(5, "KL Rahul");
            dict.Add(6, "Jadeja");
            dict.Add(7, "Bhuvi");
            dict.Add(8, "Chris gayle");
            dict.Add(9, "Sachin");
            dict.Add(10, "Bravo");
            dict.Add(11, "Dhawan");
            foreach (var players in dict)
            {
                Console.WriteLine(players);
            }

        }
        /*8. Write code in c# - The class Computation implements two interfaces, Addition and Multiplication having
        two data members Add() and Multiply() for respective interfaces and also write the logic to get the two
        numbers input from user and find the sum and product.*/
        public void addition()
        {
            Console.WriteLine("enter a value:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b value:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);
        }
        public void multiply()
        {
            Console.WriteLine("enter c value:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter d value:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c * d);
        }

        /*10. Create the Student Generic List using the properties ID, Name and Age and write a LINQ query to
        display the name of teenager students.*/
        public void teenagersData()
        {
            List<Student> listOfStudents = new List<Student>
            {
                new Student() { ID = 101, Name = "lokesh", Age = 25 },
                new Student() { ID = 102, Name = "ravi", Age = 17 },
                new Student() { ID = 103, Name = "Anurag", Age = 15 },
                new Student() { ID = 104, Name = "mani", Age = 22 },
                new Student() { ID = 105, Name = "balu",  Age = 21 },
                new Student() { ID = 106, Name = "manoj",  Age = 12 }
            };
            var teenagers = from l in listOfStudents where l.Age >= 18 select l;
            foreach (Student studentData in teenagers)
            {
                Console.WriteLine("Name:"+studentData.Name+"Age:"+studentData.Age);
            }
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
