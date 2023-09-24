/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: 
** Date: 2021 - 10 - 22
** Description: 
** Verify the random capabilities of this program
**
********/

using System;
using static System.Console;
using System.Security.Cryptography;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            const int THADS_BYTES = 4;
            byte[] byteArray = new byte[THADS_BYTES];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetBytes(byteArray);

            const int a = THADS_BYTES;
            int b = ;

            WriteLine("{0} + {1} = {2}", a, b, a + b);
            WriteLine("{0} - {1} = {2}", a, b, a - b);
            WriteLine("{0} * {1} = {2}", a, b, a * b);
            WriteLine("{0} / {1} = {2}", a, b, a / b);
            WriteLine("{0} % {1} = {2}", a, b, a % b);
        }
    }
}
