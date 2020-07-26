using System;

namespace QAvisualS
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'a';
            var firstName = "jmeno";
            var isWorking = true;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("Please write what you want to be displayed back:");
            var consoleInput = Console.ReadLine();
            Console.WriteLine("Your input was:" + " " + consoleInput);
            //var number = 2;
            //var count = 10;
            //var totalprice = 20.95f;
            //var character = 'a';
            //var firstname = "jmeno";
            //var isworking = true;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            const float Pi = 3.14f;
            Console.WriteLine(Pi);
            int integer = 10;
            byte bite = (byte)integer;
            Console.WriteLine(bite);
            string stringNumber = "kdjsakjhsakdjshi";
            int convertedInt = Convert.ToInt32(stringNumber);
            Console.WriteLine(convertedInt);
            try
            {
                string stringnumbertry = "eqweqsdfdsf";
                int convertedinttry = Convert.ToInt32(stringnumbertry);
                Console.WriteLine(convertedinttry);
            }
            catch (Exception)
            {
                Console.WriteLine("could not be converted");
            }
            var a = true;
            var b = false;
            var c = 3;
            var d = 4;
            var e = ++d;
            var f = d++;
            Console.WriteLine((float)c / (float)d);
        }
    }
}
