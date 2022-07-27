using System;

namespace HelloCsharp
{

    class Program
    {

        static void Main(string[] args)
        {

                Console.WriteLine("CHAPTER 2 EXERCISES  ");      

            //1.Declare several variables by selecting for each one of them the most appropriate of the types sbyte, byte, short, ushort, int, uint, long and ulong in order to assign them the following values:
            float value1 = 52.130F;
            sbyte value2 = -115;
            byte value3 = 97;
            long value4 = -10000;
            ushort value5 = 20000;
            byte value6 = 224;
            int value7 = 970700000;
            byte value8 = 112;
            sbyte value9 = -44;
            int value10 = -1000000;
            ushort value11 = 1990;
            ulong value12 = 123456789123456789;

            //2. Which of the following values can be assigned to variables of type float, double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467 ?
            float value13 = 5;
            float value14 = -5.01f;
            double value15 = 34.567839023;
            float value16 = 12.345f;
            double value17 = 8923.1234857;
            decimal value18 = 3456.091124875956542151256683467m;

            //3. Write a program, which compares correctly two real numbers with accuracy at least 0.000001.            
            bool result = false;
            Console.WriteLine("Enter the first number:");
            double number1 = double.Parse(Console.ReadLine());
            //string sNumber1 = Convert.ToString(number1);
            Console.WriteLine("Enter the second number:");
            double number2 = double.Parse(Console.ReadLine());
            double deduction = number1 - number2;
            deduction = Math.Abs(deduction);
            Console.WriteLine(deduction);
            if (deduction < 0.000001)
            {
                result = true;
            }
            Console.WriteLine("({0};{1});{2}", number1, number2, result);

            //4. Initialize a variable of type int with a value of 256 in hexadecimal format (256 is 100 in a numeral system with base 16).
            int varInt = 0x100;
            Console.WriteLine(varInt);

            //5.Declare a variable of type char and assign it as a value the character, which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).
            char varChar = '\u0048';
            Console.WriteLine(varChar);

            //6.Declare a variable isMale of type bool and assign a value to it depending on your gender.
            bool isMale = false;
            Console.WriteLine(isMale);

            //7.Declare two variables of type string with values "Hello" and "World".Declare a variable of type object. 
            //Assign the value obtained of concatenation of the two string variables(add space if necessary) to this variable.
            //Print the variable of type object.
            string hello = "Hello";
            string world = "World";
            object sayHello = hello + " " + world;
            Console.WriteLine(sayHello);

            //8.Declare two variables of type string and give them values "Hello" and "World".Assign the value obtained by the concatenation
            //of the two variables of type string(do not miss the space in the middle) to a variable of type object.Declare a third variable of
            // type string and initialize it with the value of the variable of
            //type object(you should use type casting).
            string sayHello2 = (string)sayHello;

            //9.Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” (without the outer quotes). 
            //In one of the variables use quoted string and in the other do not use it.
            string quotes1 = "The \"use\" of quotations causes difficulties.";
            string quotes2 = "\"The \"use\" of quotations causes difficulties.\"";
            Console.WriteLine(quotes1);
            Console.WriteLine(quotes2);

            //10.Write a program to print a figure in the shape of a heart by the sign "o".
        Console.WriteLine("  0        0 ");
        Console.WriteLine("0   0    0   0");
        Console.WriteLine(" 0   0  0   0");
        Console.WriteLine("  0   00   0");
        Console.WriteLine("   0      0 ");
        Console.WriteLine("    0    0  ");
        Console.WriteLine("     0  0   ");
        Console.WriteLine("      00   ");

            //11.Write a program that prints on the console isosceles triangle which sides consist of the copyright character "©".       
        Console.WriteLine("    ©");
        Console.WriteLine("   © ©");
        Console.WriteLine("  ©   ©");
        Console.WriteLine(" ©     ©");
         Console.WriteLine("©©©©©©©©");

            //12.2. A company dealing with marketing wants to keep a data record of itsemployees. Each record should have the following characteristic – first 
            //name, last name, age, gender (‘m’ or ‘f’) and unique employee number 
            //(27560000 to 27569999). Declare appropriate variables needed to 
            //maintain the information for an employee by using the appropriate data 
            //types and attribute names. 
             string firstName;
              string lastName;
              byte age;
             char gender;
            int id;

            //13.Declare two variables of type int. Assign to them values 5 and 10 
                //respectively. Exchange (swap) their values and print them.
                 int a = 5;
                int b = 10;
                 a = a + b;
                 b = a - b;
                 a = a - b;
                 Console.WriteLine("a:{0} b:{1}", a, b);



                        Console.WriteLine("CHAPTER 3 EXERCISES  ");

                //1.Write an expression that checks whether an integer is odd or even.
                int number = 16;
                bool even = number % 2 == 0 ? true : false;
                Console.WriteLine("{0} is even? {1}", number, even);

                //2.Write a Boolean expression that checks whether a given integer is 
                //divisible by both 5 and 7, without a remainder.
                int numeral  = 36;
                bool divisible = number % 35 == 0 ? true : false;
                Console.WriteLine("{0} is divisible by both 5 and 7? {1}", number, even);

                //3.Write an expression that looks for a given integer if its third digit (right 
                 //to left) is 7.
                  int nmb = 45764;
                  bool isSeven = (number / 100) % 10 == 7 ? true : false;
                 Console.WriteLine("Third digit of {0} is 7", number, even);

                 //4.Write an expression that checks whether the third bit in a given integer 
                 //is 1 or 0.
                 int numbr = 452;    
             Console.WriteLine("The third bit of {0} is 1? {1}", number, ((number >> 3) & 1) == 1);

             //5.Write an expression that calculates the area of a trapezoid by given 
                //sides a, b and height h.
                    float A = 2;
                    float B = 3;
                    float H = 1;
                    Console.WriteLine("S={0}", (A + B) / (2 * H));

                    //6.Write a program that prints on the console the perimeter and the area 
                        //of a rectangle by given side and height entered by the user.
                        Console.Write("Enter c: ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter d: ");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("S={0}, P={1}", c * d, (c + d) * 2);

                    //7.The gravitational field of the Moon is approximately 17% of that on the 
                   // Earth. Write a program that calculates the weight of a man on the 
                   // moon by a given weight on the Earth.
                    Console.WriteLine("Enter weight of a man: ");
                int weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("This person will weight {0}kg on the Moon.", weight * 0.17);

                 //8. Write an expression that checks for a given point {x, y} if it is within 
                //the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of 
                //the circle and 5 is the radius.
                Console.Write("Enter x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter y: ");
                int y = Convert.ToInt32(Console.ReadLine());
                bool isInside = (x *  + y * y <= 5) ? true : false;
                Console.WriteLine("The point O({0},{1}) is inside K((0,0),5)?: {2}", x, y, isInside);

                //9.Write an expression that checks for given point {x, y} if it is within the  
               // circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. 
                //Clarification: for the rectangle the lower left and the upper right corners 
                //are given.
                Console.Write("Enter t: ");
            int t = Convert.ToInt32(Console.ReadKey());
            Console.Write("Enter f: ");
            int f = Convert.ToInt32(Console.ReadKey());
            bool isInsideCircle = (t * t + f * f <= 5) ? true : false;
            bool isOutsideRectangle = (t < -1 && x > 5 && f < 1 && f > 5) ? true : false;
            Console.WriteLine("The point O({0},{1}) is inside K((0,0),5)?: {2}", t, f, isInsideCircle);
            Console.WriteLine("The point O({0},{1}) is outside rectangle ((-1, 1), (5, 5)?: {2}", t, f, isOutsideRectangle);


        //10.Write a program that takes as input a four-digit number in format abcd
               // (e.g. 2011) and performs the following actions:
               // - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
               // - Prints on the console the number in reversed order: dcba (in our 
               // example 1102).
               // - Puts the last digit in the first position: dabc (in our example 1201).
               // - Exchanges the second and the third digits: acbd (in our example 
               // 2101)
                Console.Write("Enter number: ");
            int numer = Convert.ToInt32(Console.ReadLine());
            int a = number / 1000;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;

            Console.WriteLine("1.Sum of digits = {0}", a + b + c + d);
            Console.WriteLine("2.Digits backwards = {3}{2}{1}{0}", a, b, c, d);
            Console.WriteLine("3.Last digit on first place = {3}{0}{1}{2}", a, b, c, d);
            Console.WriteLine("4.Replace third and second digit = {0}{2}{1}{3}", a, b, c, d);

            //11.We are given a number n and a position p. Write a sequence of 
                //operations that prints the value of the bit on the position p in the 
                //number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, 
                //p=6 -> 0.
                
            int n = 35, p = 6, i = 1, mask = i << p;
            Console.WriteLine((n & mask) != 0 ? "Third bit is 1" : "Third bit is 0");    

            //12.Write a Boolean expression that checks if the bit on position p in the 
                //integer v has the value 1. Example v=5, p=1 -> false.
                int v = 350;
                int p = 350;
                int mask = 1 << p;
                bool isOne = (v & mask) != 0 ? true : false;
                Console.WriteLine("The bit at position {0}of number {1} is 1? {2}", p, v, isOne);

                //13. We are given the number n, the value v (v = 0 or 1) and the position p. 
                //write a sequence of operations that changes the value of n, so the bit on 
                //the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. 
                //Another example: n=35, p=2, v=1 -> n=39.
                
                    int n = 350;
                    int v = 0;
                    int p = 3;
                    n = (v == 0) ? n = n & (~(1 << p)) : n = n | (1 << p);
                    Console.WriteLine(n);

                    //14.Write a program that checks if a given number n (1 < n < 100) is a 
            //prime number (i.e. it is divisible without remainder only to itself and 1).
             int number = 72;
            bool isPrime = true;
            if (number > 2)
                for (int i = 2; i <= Math.Ceiling(Math.Sqrt(numbber)); ++i)
                {
                    if (number % i == 0) isPrime = false;
                }
            Console.WriteLine("{0} is prime?: {1}", number, isPrime);

            //15.* Write a program that exchanges the values of the bits on positions 
            //3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32-bit unsigned 
            //integer.
             Console.Write("Enter number: ");
            int v = Convert.ToInt32(Console.ReadLine());
            int mask = 1 << 3;
            int bitAt3 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 4;
            int bitAt4 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 5;
            int bitAt5 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 24;
            int bitAt24 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 25;
            int bitAt25 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 26;
            int bitAt26 = (v & mask) != 0 ? 1 : 0;

            v = (bitAt3 == 0) ? v = v & (~(1 << 24)) : v = v | (1 << 24);
            v = (bitAt4 == 0) ? v = v & (~(1 << 25)) : v = v | (1 << 25);
            v = (bitAt5 == 0) ? v = v & (~(1 << 26)) : v = v | (1 << 26);
            v = (bitAt24 == 0) ? v = v & (~(1 << 3)) : v = v | (1 << 3);
            v = (bitAt25 == 0) ? v = v & (~(1 << 4)) : v = v | (1 << 4);
            v = (bitAt26 == 0) ? v = v & (~(1 << 5)) : v = v | (1 << 5);

            Console.WriteLine(v);

            //16.* Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, 
                //q+1, …, q+k-1} of a given 32-bit unsigned integer.
                 int[] pBits = new int[k];
            int[] qBits = new int[k];

            for (int position = p, i = 0; i < pBits.Length; position++, i++)
            {
                pBits[i] = PthBit(number, position);
            }

            for (int position = q, i = 0; i < qBits.Length; position++, i++)
            {
                qBits[i] = PthBit(number, position);
            }

            for (int position = p, i = 0; i < qBits.Length; position++, i++)
            {
                number = ModifiedNumber(number, position, qBits[i]);
            }

            for (int position = q, i = 0; i < pBits.Length; position++, i++)
            {
                number = ModifiedNumber(number, position, pBits[i]);
            }
            return number;
        }

        private static int PthBit(uint number, int position)
        {
            uint pthBit = (number >> position) & 1;
            return (int)pthBit;
        }

        private static uint ModifiedNumber(uint number, int position, int bitValue)
        {
            uint actualP = (uint)bitValue << position;
            number = number & (~((uint)1 << position));
            uint result = number | actualP;
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.Write("Enter p: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter q: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());


            if (p > q)
            {
                int oldValue = p;
                p = q;
                q = oldValue;
            }

            if (p + k >= q)
            {
                k += p - q - 1;
                q += p + k + 1;
            }

            number = ModifyNumber(number, p, q, k);

            Console.WriteLine(number);



        
        










    

        







        }





    }






}
