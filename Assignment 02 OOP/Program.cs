using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace Assignment_02_OOP
  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] p1 = new Person[3];
            //p1[0]= new Person("Ali", 20);
            //p1[1] = new Person("Ahmed", 25);
            //p1[2] = new Person("Omar", 30);

            //foreach(var item in p1)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Console.WriteLine("===============================");

            //for(int i=0; i<p1.Length; i++) {

            //    Console.WriteLine(p1[i].ToString());
            //}

            #endregion
            #region Q2.Create a struct called "Point" to represent a 2D point with properties "X" and   "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.WriteLine("Enter the first point");
            //Point p1 = new Point();
            //p1.Createpoint();

            //Console.WriteLine("Enter the second point");    
            //Point p2 = new Point();
            //p2.Createpoint();

            //Console.WriteLine($"The distance between the two points is {p1.Distance(p1, p2)}"); 

            #endregion
            #region Q3.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] p1 = new Person[3];
            //Person max = p1[0];
            //for (int i = 0; i < p1.Length; i++)
            //{
            //    Console.WriteLine($"Enter the name of the person {i+1}");
            //    string name = Console.ReadLine();
            //    Console.WriteLine($"Enter the age of the person {i+1}");
            //    int age;
            //    bool isparsed;
            //    do
            //    {
            //        isparsed = int.TryParse(Console.ReadLine(), out age);
            //        if (!isparsed)
            //        {
            //            Console.WriteLine("Please enter a valid number");
            //        }
            //    } while (!isparsed);

            //    p1[i] = new Person(name, age);

            //    if (p1[i].Age > max.Age)
            //    {
            //        max = p1[i];
            //    }
            //}

            //Console.WriteLine($"The oldest person is {max.Name} and his age is {max.Age}");


            #endregion
            #region Q4.Create a struct named Rectangle 
            //Rectangle rectangle = new Rectangle(2,3);
            //Console.WriteLine(rectangle.ToString());
            //Console.WriteLine($"The area of the rectangle is {rectangle.Area}");



            #endregion

        }

    }
}
