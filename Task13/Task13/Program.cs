using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(15);
            Vector vector2 = new Vector(15);
            vector1.MethodPrint("Vector1");
            vector2.MethodPrint("Vector2");
            try
            {
                vector1.SetElement(10, 20);
            }
            catch (MyException myException)
            {
                Console.WriteLine($"{myException.Message}");
            }
            
            try
            {
                Console.WriteLine($"Get Verification {vector1.GetElement(20)}");
            }
            catch (MyException myException)
            {
                Console.WriteLine($"{myException.Message}");
            }

            try
            {
                vector1.Addition(vector2, 5, 6).MethodPrint("Addited vectors");
            }
            catch (MyException myException)
            {
                Console.WriteLine($"{myException.Message}");
            }


            try
            {
                vector1.Substraction(vector2, 5, 6).MethodPrint("Substracted vectors");
            }
            catch (MyException myException)
            {
                Console.WriteLine($"{myException.Message}");
            }

            try
            {
                (vector1*3).MethodPrint("Substracted vectors");
            }
            catch (MyException myException)
            {
                Console.WriteLine($"{myException.Message}");
            }
            Console.ReadKey();
        }
    }
}
