


//using Ext.Net;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace OOP2019

{

    class Program

    {

        static void Main(string[] args)

        {



            //Exercise 1



            int x = ReadInt("Type a number: ");

            int y = ReadInt("Type another number: ");

            Console.WriteLine($"{x} + {y} = {x + y}");

            Console.ReadLine();



            //Exercise 2



            Console.WriteLine(" -- Amazing Leap Year Calculator 2019 --");

            Console.WriteLine(" -- Choose two years between 1 to 9999 --");

            int c = ReadInt("Type the first year: ");

            int d = ReadInt("Type another year: ");

            for (int ye = c; ye <= d; ye++)

            {

                if (DateTime.IsLeapYear(ye))

                {

                    Console.WriteLine(ye + "" + " * ");

                }



                else

                {

                    Console.WriteLine(ye);

                }

            }

            Console.ReadLine();



            //Exercise 3





            Console.WriteLine((IsPalindrome("---Write a word to check if it is Palindrome---")));



            //Exercise 4 FizzBuzz



            Console.WriteLine(" --- Welcome to FizzBuzz --- ");



            for (int i = 1; i <= 100; i++)

            {

                if (i % 3 == 0 && i % 5 == 0)

                {

                    Console.WriteLine("FizzBuzz");

                }

                else if (i % 3 == 0)

                {

                    Console.WriteLine("Fizz");

                }

                else if (i % 5 == 0)

                {

                    Console.WriteLine("Buzz");

                }

                else

                {

                    Console.WriteLine(i);

                }

            }

            Console.ReadLine();

            //Exercise 5



            var random = new Random();

            var number = random.Next(1, 99);





            Console.WriteLine(" Guess a number between 1 to 99 ");

            var num = Convert.ToInt32(Console.ReadLine());



            if (num < number)

            {

                Console.WriteLine(" This is   to low ");



            }

            else if (num > number)

            {

                Console.WriteLine(" This is  too high  ");



            }

            else

            {

                Console.WriteLine(" This is correct " + number);



            }



            Console.ReadLine();





            //Exercise 6



            var random1 = new Random();

            var number1 = random1.Next(1, 99);

            var gu = 61;



            Console.WriteLine(" Guess a number between 1 to 99 ");

            var num1 = Convert.ToInt32(Console.ReadLine());





            if (gu < number1)

            {

                Console.WriteLine(" Computer guesses the number " + " " + number1 + " " + " and it is too high ");



            }

            else if (gu > number1)

            {

                Console.WriteLine(" Computer guesses the number " + " " + number1 + " " + " and it is too low ");



            }

            else if (gu == number1)

            {

                Console.WriteLine(" This is correct " + " " + number1);

                Console.WriteLine("*Computer is winner*");



            }

            if (num1 < gu)

            {

                Console.WriteLine(" Human choice  is to low ");



            }

            else if (num1 > gu)

            {

                Console.WriteLine(" human choice is to high ");



            }

            else if (num1 == gu)

            {

                Console.WriteLine(" This is correct " + "" + number1);

                Console.WriteLine(" *Human is winner*");



            }

            else

            {

                Console.WriteLine("**Both human and Computer are Winners**");

            }





            Console.ReadLine();



            //Exercise 7





            //var random2 = new Random();

            //var color = random2.Next(8, 16);   // 16 is exclusive

            //var Height = random2.Next(5, 16);

            //var Width = random2.Next(5, 19);

            //Console.BackgroundColor = (ConsoleColor)color;

            //Console.WindowHeight = Height;

            //Console.WindowWidth = Width;

            //Console.SetCursorPosition(0, 0);

            //Console.Write(" ");   // draw a box in some random color

            //Console.ReadLine();



            //Exercise 8





            int n = ReadInt("Please enter the number of triangles in your tree: ");



            for (int i = 1; i <= n; i++)

            {

                for (int j = 0; j < i; j++)

                {

                    string branch = new String('*', j);

                    Console.WriteLine(branch.PadLeft(n + 3) + "*" + branch);

                }

            }

            Console.ReadLine();



            //Exercise 9



            var map = Showmap("map.txt");

            Console.WriteLine(map);

            var data = ReadMap("map.txt");

            var land = CalculateNumberOfLandTiles(data);



            Console.WriteLine($"Number of land tiles in map: {land}");



            Console.ReadLine();



            //Exercise 10



            var invader = new[,]

             {

                                { 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0 },

                                { 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0 },

                                { 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0 },

                                { 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0 },

                                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },

                                { 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1 },

                                { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },

                                { 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0 }

                            };

            string[] invaderString = new string[invader.GetLength(0)];

            for (int i = 0; i < invader.GetLength(0); i++)

            {

                string stringbuilder = string.Empty;

                for (int j = 0; j < invader.GetLength(1); j++)

                {

                    stringbuilder += invader[i, j] == 0 ? "  " : "**";



                }

                invaderString[i] = stringbuilder;

                Console.WriteLine(stringbuilder);

            }





            {

                Random random4 = new Random();

                var nmb = random4.Next(1, 5);

                int left = 0;

                int right = 0;

                int up = 0;

                int down = 0;

                _ = nmb == 1 ? left = 1 : nmb == 2 ? right = 1 : nmb == 3 ? up = 1 : down = 1;

                Console.MoveBufferArea(left, up, 50, 50, right, down);

                System.Threading.Thread.Sleep(500);

            }



            Console.ReadLine();





            //Exercise 11





            var formula = "1 + 2 * 3";

            var result = CalculateString(formula);

            Console.WriteLine($"{formula} = {result}");



            formula = "4 - 50 * 3 + 200 + 18 / 4";

            result = CalculateString(formula);

            Console.WriteLine($"{formula} = {result}");



            Console.ReadLine();

            //Exercise 12





            var block = new byte[,] {

                            { 0, 0, 0 },

                            { 1, 1, 1 },

                            { 0, 1, 0 },

                        };

            block = RotateLeft(block);

            block = RotateLeft(block);



            for (int i = 0; i < block.GetLength(0); i++)

            {

                for (int k = 0; k < block.GetLength(1); k++)

                {

                    Console.Write(block[i, k]);

                }



                Console.WriteLine();

            }









            while (true) ;



        }





        ///Metods/////



        //ReadInt

        private static int ReadInt(string l)

        {

            Console.WriteLine(l);

            var v = Console.ReadLine();

            int a;

            while (!int.TryParse(v, out a))

            {

                Console.WriteLine("This is not a number!");

                v = Console.ReadLine();

            }



            return a;

        }



        //IsPalindrome



        public static bool IsPalindrome(string s)

        {

            Console.WriteLine(s);

            string d = Console.ReadLine();

            char[] rev = d.ToCharArray();

            Array.Reverse(rev);

            string de = new string(rev);



            while (d != de)

            {

                Console.WriteLine("False");

                Console.ReadLine();

            }

            return true;

        }

        //ReadMap, Showmap , CalculateNumberOfLandTiles



        public static string Showmap(string file)

        {



            string text = System.IO.File.ReadAllText(@"C:\Users\sanaz\Desktop\Test\" + file);

            //Console.WriteLine(text);

            return text;

        }



        public static string[] ReadMap(string fileName)

        {



            string[] map = System.IO.File.ReadAllLines(@"C:\Users\sanaz\Desktop\Test\" + fileName);



            return map;

        }



        public static int CalculateNumberOfLandTiles(string[] map)

        {

            int land = 0;

            foreach (string line in map)

            {

                land += line.Split('#').Length - 1;

            }



            return land;

        }



        //CalculateString



        public static int CalculateString(string formula)

        {



            int number = 0;

            char currentSymbol = '+';

            string[] tokens = formula.Split(' ');



            foreach (string item in tokens)

            {

                bool isNumber = int.TryParse(item, out int nmb);

                _ = isNumber == false ? currentSymbol = item[0] : currentSymbol == '-' ? number -= nmb : currentSymbol == '+' ? number += nmb : currentSymbol

                    == '/' ? number /= nmb : number *= nmb;



            }



            return number;

        }





        //RotateLeft



        public static byte[,] RotateLeft(byte[,] block)

        {



            var block2 = new byte[block.GetLength(0), block.GetLength(1)];

            for (int i = 0; i < block.GetLength(0); i++)

            {

                for (int j = 0; j < block.GetLength(1); j++)

                {

                    block2[2 - j, i] = block[i, j];

                }

            }





            return block2;

        }

    }

}



