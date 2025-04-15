// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
    couple of lines comment  
    couple of lines comment  
    couple of lines comment  
*/

using System;

namespace HelloWorld {
    class Program {
        static void Main() { 
            Console.WriteLine("Hello, World!");
            Console.Write("1 ");
            Console.Write("2 \n\n");
            Console.Write("3 ");
            Console.Write("\n");

            // START Variables

            int varForNumbers = 40;
            const uint constForPositiveNumbers = 2;
            varForNumbers = varForNumbers + (int)constForPositiveNumbers;
            byte from0to255 = 255;
            short fromMinus32768to32767 = -32768;
            long realyBigNumber = 1234567890123456789;
            float varForDecimalNumbers = 3.14f;
            double reallyBigDecimalNumber = 3.141592653589793238d;

            bool a, b;
            a = true;
            b = false;

            string someString = " lalaley ";
            char oneSymbol = 'a';
            //Console.WriteLine(Console.ReadLine() + " " +a + " " + b + " " + varForNumbers + someString + reallyBigDecimalNumber + " " + varForDecimalNumbers + " " + realyBigNumber + " " + oneSymbol + fromMinus32768to32767 + " " + from0to255);



            // END Variables

            //Start Convert

            //float user_input = Convert.ToDouble(Console.ReadLine());
            float user_input;
            user_input = 5.5f;
            //user_input = float.Parse(Console.ReadLine());
            Console.WriteLine("User input: " + user_input);

            string strNumber = "404";
            int converted = Convert.ToInt32(strNumber);

            //End Convert

            //Start Math

            float result = (user_input + 10f) % 10f;
            result += 13f;
            result++;
            Console.WriteLine("Result: " + result);

            Console.WriteLine(Math.PI + " " + Math.Abs(-333));
            Console.WriteLine(Math.Floor(4.1f) + " " + Math.Ceiling(4.1f) + " " + Math.Round(4.51f) + " " + Math.Round(4.49f));
            Console.WriteLine("Min: {0}, Max: {1}, 3**3: {2}\n", Math.Min(3,4), Math.Max(3, 4), Math.Pow(3,3));


            //End Math

            //Start If Else

            byte aByte = 10;
            Console.Write("input smal number: ");
            byte bByte = Convert.ToByte(Console.ReadLine());
            //byte bByte = 20;
            if (aByte > bByte) 
                Console.WriteLine("aByte > bByte\n");
            else if (aByte == bByte)
                Console.WriteLine("aByte == bByte\n");
            else {
                Console.WriteLine("aByte < bByte\n");
            }

            //!! also can be !=, >=, <=, || or, && and, ! not

            bool isLalaley = someString != " lalaley ";
            if (isLalaley)
            {
                //do something
            } else {
                Console.WriteLine("someString still is lalaley \n");
            }

            Console.WriteLine((false || 2 > 4 || 2 < 4) + " " + (true && 5 != 5));
            

            //END If Else


        }
    }
}