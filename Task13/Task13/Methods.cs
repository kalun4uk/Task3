using System;
using System.Threading;

namespace Task13
{
    partial class Vector
    {
        /// <summary>
        /// Initialization method put the random numbers to the vector
        /// </summary>
        public void Initialization()
        {
            var rand = new Random();
            for (var i = 0; i < Size; i++)
            {
                SetElement(rand.Next(0,100), i);
            }
            Thread.Sleep(10);
        }

        /// <summary>
        /// Get size of the vector
        /// </summary>
        public int Size
        {
            get { return vector.Length; }
        }

        /// <summary>
        /// Get element of the vector with verification (out of range)
        /// </summary>
        /// <param name="index">Index of the element we need to get</param>
        /// <returns>Element of the vector</returns>
        public int GetElement(int index)
        {
            if (index >= Size) throw new MyException("Index is out of range");
            return vector[index];
        }

        /// <summary>
        /// Set element of the vector
        /// </summary>
        /// <param name="value">value element to set</param>
        /// <param name="index">index of the element to set</param>
        public void SetElement(int value, int index)
        {
            if (index >= Size) throw new MyException("Index is out of range");
            vector[index] = value;
        }

        /// <summary>
        /// Verification of the vectors: is they equal
        /// </summary>
        /// <param name="vec1">Object of the first vector</param>
        /// <param name="vec2">Object of the second vector</param>
        /// <returns>Bool value of the verification</returns>
        public bool VerificationVectors(Vector vec1, Vector vec2)
        {
            if (!VerificationLenght(vec1, vec2)) return false;
            for (var i = 0; i < vec1.Size; i++)
            {
                if (vec1.GetElement(i) != vec2.GetElement(i)) return false;
            }
            return true;
        }

        /// <summary>
        /// Compares lengths of the vectors and returns the bool result
        /// </summary>
        /// <param name="vec1">Object of the first vector</param>
        /// <param name="vec2">Object of te second vector</param>
        /// <returns>bool value of the result</returns>
        public bool VerificationLenght(Vector vec1, Vector vec2) => vec1.Size == vec2.Size;


        /// <summary>
        /// get vector that consist of the addition of the first and second
        /// </summary>
        /// <param name="vect1"></param>
        /// <param name="start">start index to add</param>
        /// <param name="end">end index to add</param>
        /// <returns>Added vector</returns>
        public Vector Addition(Vector vect1, int start, int end)
        {
            for (var i = start; i <= end; i++)
            {
                SetElement(GetElement(i) + vect1.GetElement(i), i);
            }
            return this;
        }

        /// <summary>
        /// get vector multiplication on the number
        /// </summary>
        /// <param name="vector">vector to multiplicate</param>
        /// <param name="number">number to multiplicate</param>
        /// <returns>Vector and number multiplication</returns>
        public static Vector operator *(Vector vector, int number)
        {
            for (var i = 0; i < vector.Size; i++)
            {
                vector.SetElement(vector.GetElement(i) * number, i);
            }
            return vector;
        }
        
        /// <summary>
        /// get vector that consist of the substraction of the first and second
        /// </summary>
        /// <param name="vect1"></param>
        /// <param name="start">start index to substract</param>
        /// <param name="end">end index to substract</param>
        /// <returns>Substracted vector</returns>
        public Vector Substraction(Vector vect1, int start, int end)
        {
            for (var i = start; i <= end; i++)
            {
                SetElement(GetElement(i) - vect1.GetElement(i), i);
            }
            return this;
        }

        /// <summary>
        /// To print the vector
        /// </summary>
        /// <param name="str">String of the instruction</param>
        public void MethodPrint(string str)
        {
            Console.WriteLine(str);
            for (var i = 0; i < Size; i++)
            {
                if (i + 1 == Size)
                {
                    Console.WriteLine($"{GetElement(i)}  ");
                    break;
                }
                Console.Write($"{GetElement(i)}  ");
            }
        }
    }
}
