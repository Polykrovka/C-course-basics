// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
    couple of lines comment  
    couple of lines comment  
    couple of lines comment  
*/

using System;
using System.Collections.Generic; //For dinnamic array list
using System.IO; // input outstream for working with files

namespace HelloWorld {
    class Program {
        // static can call without creating object
        // void is no return type
        static void Main() {
            //PreviosLessons(); 
            //TryCatch();
            usingRobotClass();
            //isAndAs();



        }

        public static void isAndAs() {

            //array of pointers (массив указателей)
            List<RobotKiller> robots = new List<RobotKiller>();
            robots.Add(new RobotKiller("Alex", 400, new byte[] { 1, 2, 3 }, 100));
            robots.Add(new RobotKiller("Bob", 400, new byte[] { 1, 2, 3 }, 100));
            robots.Add(new RobotKiller("Jeam", 400, new byte[] { 1, 2, 3 }, 100));
            robots.Add(new RobotKiller("lol", 400, new byte[] { 1, 2, 3 }, 100));

            Robot newRobot = null;

            foreach(RobotKiller objBot in robots) {
                if(objBot.Name == "Jeam") {
                    //As operator we can use to do something with the object as an object of different class
                    newRobot = objBot as Robot;
                    //newRobot.Laser(); can not use because it is not a method of the Robot class
                }
                //is operator we can use to check if the object is of the specified type. For derived classes will be true because they are also of the base class type
                Console.WriteLine("{0} is Robot: {1}", objBot.Name, objBot is Robot);

            }

            float number = 5.5f;
            Console.WriteLine(number is int);



        }
        public static void usingRobotClass() {
            Robot bot = new Robot("Robo", 800, new byte[] { 1, 2, 3 });
            bot.printValues();

            RobotKiller killer = new RobotKiller("killer", 1000, new byte[] { 4, 5, 6 }, 1000);
            killer.printValues();
            //killer.Health = 100; //Use accessor to set the health
            killer.Lazer(); //Use method from the derived class


            Robot bot3 = new Robot();
            bot3.Weight = -100; //Use accessor to set the weight
            Console.WriteLine(bot3.Weight);

            Robot.Print(); //Static method

            bot3.Width = 100;
            //Console.WriteLine(bot3.Width); can not use get because it is private but still can use set
        }
        public static byte ArraySum(byte[] digits) { 
            byte sum = 0;
            foreach( byte el in digits)
                sum += el;
            return sum;
        }
        public static void Print(string str) {
            Console.WriteLine(str);
        }

        public static int Sum(int x, int y){  
            return x + y;
        }

        public static void TryCatch() {
            try {
                Console.Write("Enter a number: ");
                int numY = 10, numX, res;
                numX = Convert.ToInt32(Console.ReadLine());

                res = numY / numX;
                Console.WriteLine("10 / {0} = {1}", numX, res);
            } catch(FormatException) {
                Console.WriteLine("Frong format");
            } catch(DivideByZeroException) {
                Console.WriteLine("You can not divide by zero");
            } finally {
                Console.WriteLine("Finally");
            }
        }

        public static void PreviosLessons(){
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
            Console.WriteLine("Min: {0}, Max: {1}, 3**3: {2}\n", Math.Min(3, 4), Math.Max(3, 4), Math.Pow(3, 3));


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
            else
            {
                Console.WriteLine("aByte < bByte\n");
            }

            //!! also can be !=, >=, <=, || or, && and, ! not

            bool isLalaley = someString != " lalaley ";
            if (isLalaley)
            {
                //do something
            }
            else
            {
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

            for (byte i = 0; i < 10; i++)
            {
                if (i > 5 && i < 8)
                    continue;
                Console.Write("i = {0} ;", i);
            }

            Console.WriteLine();

            byte i2 = 0;
            while (i2 < 10)
            {
                if (i2 > 5)
                    break;
                Console.Write("i = {0} ;", i2);
                i2++;
            }

            Console.WriteLine();

            do
            {
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

            for (int i = 0; i < words.Length; i++)
                Console.WriteLine("words[{0}] = {1}", i, words[i]);

            short[] numbers = new short[5];

            Random random = new Random();
            short sum = 0;

            for (byte i = 0; i < numbers.Length; i++)
            {
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

            foreach (byte el in array)
            {
                Console.WriteLine("foreach: " + el);
            }

            foreach (byte el in numsMatrix)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();

            List<int> numbersArr = new List<int>() { 7, 2, 3 };

            numbersArr.Add(44);
            numbersArr.Add(55);
            numbersArr.Add(1);

            numbersArr.Remove(44);
            numbersArr.Sort();
            numbersArr.Reverse();

            // Array.Sort(numbers); Array.Reverse(numbers); for normal array

            foreach(int el in numbersArr)
            {
                Console.WriteLine("List<int>: " + el);
            }

            Console.WriteLine(numbersArr.Exists(x => x == 7) + " " + numbersArr.IndexOf(7));

            //END foreach

            //START Methods

            int res1 = Sum(2, 3);
            Print("\nResult of Sum: " + res1);
            Print(res1.ToString());

            byte[] bytesArr = { 8, 2, 3, 4, 5 };
            Console.WriteLine(ArraySum(bytesArr));

            //END Methods

            //START methods of st

            string word1 = "  Hello";
            word1 += "!!!";
            Print(word1[1].ToString()); //ToString() convert char to string becouse Print() need string
            Console.WriteLine(word1.Length);

            word1 = String.Concat(word1, "!!");
            Console.WriteLine(String.Compare(word1, "Hello!")); //1 if string shorter, 0 if equal, -1 if string longer

            string people = "Anton, Maks, Dima";

            string[] names = people.Split(", ");
            // .ToCharArray(); also can you to cplit string by chars
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            people = String.Join(" ", names);
            Console.WriteLine(people);

            Console.WriteLine("before trim: {0}, after trim: {1}", word1, word1.Trim());
            Console.WriteLine("First 3 symbols deleted by substring: {0}, remove 4 symbols from the end of the line: {1}", word1.Substring(3), word1.Substring(0, word1.Length - 4));
            Console.WriteLine(word1.ToUpper());

            //END methods of string

            //START FileStream

            const string textForFile = "Just some text\nlalala";
            //using for isolete code
            //FileStream its a class, stream is a my object, instance of class

            using (FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate))
            {
                byte[] arrayBytes = System.Text.Encoding.Default.GetBytes(textForFile);

                //0 how much elements to not write
                stream.Write(arrayBytes, 0, arrayBytes.Length);
            }

            using (FileStream loadingStream = File.OpenRead("info.txt"))
            {
                byte[] arrayBytes = new byte[loadingStream.Length];
                loadingStream.Read(arrayBytes, 0, arrayBytes.Length);

                string textFromFile = System.Text.Encoding.Default.GetString(arrayBytes);
                Console.WriteLine(textFromFile);
            }

            //END FileStream

        }
    }

}