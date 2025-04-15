// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
    couple of lines comment  
    couple of lines comment  
    couple of lines comment  
*/

using System;
using System.Collections.Generic; //For dinnamic array list

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
            //byte bByte = Convert.ToByte(Console.ReadLine());
            byte bByte = 20;
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

            //START Switch


            short someInput;
            //someInput = Convert.ToInt16(Console.ReadLine());
            someInput = 2;

            switch (someInput)
            {
                case 1:
                    Console.WriteLine("you are number is 1");
                    break;
                case 2:
                    Console.WriteLine("you are number is 2");
                    break;
                case 3:
                    Console.WriteLine("you are number is 3");
                    break;
                default:
                    Console.WriteLine("Not what i expected");
                    break;
            }


            //END Switch

            //START For, while

            for (byte i = 0; i < 10; i++) {
                if (i > 5 && i < 8)
                    continue;
                Console.Write("i = {0} ;",i);
            }

            Console.WriteLine();

            byte i2 = 0;
            while (i2 < 10) {
                if (i2 > 5)
                    break;
                Console.Write("i = {0} ;", i2);
                i2++;
            }

            Console.WriteLine();

            do {
                Console.WriteLine("Do logic before if one time");
            } while (i2 > 100);

            //END For, while

            //START Arrays

            byte[] array = new byte[5];
            array[0] = 250;
            array[1] = 0;
            array[2] = 25;
            array[3] = 20;
            array[4] = 50;


            Console.WriteLine("1 element of array: " + array[0]);

            string[] words = new string[] { "one", "two", "three", "four", "five" };
            words[1] = "2";

            for(int i = 0; i < words.Length; i++)
                Console.WriteLine("words[{0}] = {1}", i, words[i]);

            short[] numbers = new short[5];

            Random random = new Random();
            short sum = 0;

            for (byte i = 0; i < numbers.Length; i++) {
                numbers[i] = (short)random.Next(-255, 255);
                Console.WriteLine("El: " + numbers[i]);
                sum += numbers[i];
            }

            Console.WriteLine("sum = " + sum);

            //[,] for matrix array inside array
            char[,] symbols = new char[2, 3];
            symbols[0, 0] = 'a';

            int[,] numsMatrix = { 
                { 1, 2, 3},
                { 4, 5, 6},
                { 7, 8, 9}
            };

            numsMatrix[0, 0] = 10;

            for (int i = 0; i < numsMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < numsMatrix.GetLength(1); j++)
                {
                    Console.Write(numsMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            //Console.WriteLine(symbols[0, 0]);


            //END Arrays

            //START foreach

            foreach(byte el in array){
                Console.WriteLine("foreach: " + el);
            }

            foreach (byte el in numsMatrix)
            {
                Console.Write( el + " ");
            }
            Console.WriteLine();

            List<int> numbersArr = new List<int>() { 7, 2, 3};

            numbersArr.Add(44);
            numbersArr.Add(55);
            numbersArr.Add(1);

            numbersArr.Remove(44);
            numbersArr.Sort();
            numbersArr.Reverse();

            foreach (int el in numbersArr){
                Console.WriteLine("List<int>: " + el);
            }

            Console.WriteLine(numbersArr.Exists(x => x == 7) + " " + numbersArr.IndexOf(7));

            //END foreach
        }
    }
}