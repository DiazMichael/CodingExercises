using System;

namespace speedLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int speedLimit = rnd.Next(30, 120);
            Console.WriteLine($"The speed limit in this road is {speedLimit}\n");
            
            
            while (true)
            {
                try
                {
                    Console.WriteLine("What is the speed of the car?\n");
                    var speedCar = Convert.ToInt64(Console.ReadLine());

                    if (speedCar <= speedLimit && speedCar > 0)
                    {
                        Console.WriteLine("\nThank you for driving safely.\n");


                    }
                    else
                    {
                        var pointsLost = (speedCar - speedLimit) / 5;
                        if (pointsLost > 12)
                        {
                            Console.WriteLine("\nLicense Suspended\n");

                        }
                        else
                        {
                            Console.WriteLine($"\nThe driver was over the limit and loses {pointsLost} point/s\n");
                        }

                    }
                    break;


                }
                catch
                {
                    Console.WriteLine("\nError: Please input numbers\n");
                }
            }

        }


    }
}
