using System;

namespace MethodClassAssignment
{
    class MyClass
    {
        // A void method that takes two integers as parameters
        public void MyMethod(int num1, int num2)
        {
            // Perform a math operation on num1
            int result = num1 * 2;

            // Display num2 to the screen
            Console.WriteLine(num2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MyClass myClass = new MyClass();

            // Call the method in the class, passing in two numbers
            myClass.MyMethod(5, 10);

            // Call the method in the class, specifying the parameters by name
            myClass.MyMethod(num1: 3, num2: 7);

            // Keep the console window open until a key is pressed
            Console.ReadKey();
        }
    }
}
