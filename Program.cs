using System;

namespace Lesson2_DZ
{
    //Реализуйте операторы неявного приведения из long,int,byte в Bits.
 
    internal class Program
    {
        static void Main(string[] args)
        {

            Bits bitsFromLong = 1234567890123456789L;
            Bits bitsFromInt = 123456789;
            Bits bitsFromByte = 123;

            Console.WriteLine(bitsFromLong);
            Console.WriteLine(bitsFromInt); 
            Console.WriteLine(bitsFromByte);
        }
    }
}
