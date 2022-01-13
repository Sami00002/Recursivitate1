using System;

namespace Recursivitate1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[] { 1, 2, 3, 4, 5, 6 , 7 , 8 , 9 , 10 , 11 , 12};
            Recursiv.ParcurgereVector(vector, vector.Length);
        }
    }
}
