using System;

namespace redditLink
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Create a function to extract the name of the subreddit from its URL.
            var link = "https://www.reddit.com/r/relationships/";
            var separator = "/r/";
            var separatorIndex = link.LastIndexOf(separator) + 3;
            Console.WriteLine(separatorIndex);
            var result = link.Substring(separatorIndex, link.Length - separatorIndex - 2);
            Console.WriteLine(result);
        }
    }
}
