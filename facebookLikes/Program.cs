using System;
using System.Collections.Generic;
namespace facebookLikes
{
    class Program
    {
        static void Main(string[] args)
        {
            ///1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays
            ///different information.
            ///If no one likes your post, it doesn't display anything.
            ///If only one person likes your post, it displays: [Friend's Name] likes your post.
            ///If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            ///If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others
            ///like your post.
            ///Write a program and continuously ask the user to enter different names, until the user presses Enter (without
            ///supplying a name). Depending on the number of names provided, display a message based on the above pattern.
            ///

            Console.WriteLine("Please as many names as you like, press 'Enter' to send, and sent and empty command to finish.\n");
            var users = new List<string>();
            while (true)
            {
                var name = Console.ReadLine();
                if (name != "")
                {
                    users.Add(name);
                    Console.Clear();
                    Console.WriteLine("Please as many names as you like, press 'Enter' to send, and sent and empty command to finish.");
                    Console.WriteLine($"                                                             {users.Count} like/s");

                }
                else
                {
                    break;
                }
            }
            if (users.Count == 1)
            {
                Console.WriteLine($"{users[0]} likes your post.");
            }
            else if (users.Count == 2)
            {
                Console.WriteLine($"{users[0]} and {users[1]} like your post.");
            }
            else if (users.Count >= 3)
            {
                Console.WriteLine($"{users[0]}, {users[1]}, and " + (users.Count - 2) + " others like your post.");
            }
        }
    }
}
