using System;

namespace UrlFixer
{
    public class UrlFixer
    {
        public static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";
            string url2 = "https//www.reddit.com/r/nevertellmethebots";
            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!
            url = url.Replace("bots", "odds");
            url = url.Insert(5, ":");



            url2 = url2.Substring(0, url2.Length - 4);
            url2 = url2 + "odds";

            url2 = url2.Substring(0, 5) + ":" + url2.Substring(5, url2.Length - 5);

            Console.WriteLine(url);
            Console.WriteLine(url2);

            Console.ReadLine();
        }
    }
}