using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Task13
{
    /// <summary>
    /// Part of class Vector that consist of initialization of the instance
    /// </summary>
    partial class Vector
    {
        private int[] vector;

        public Vector(int size)
        {
            vector = new int[size];
            Initialization();
        }
    }
}
