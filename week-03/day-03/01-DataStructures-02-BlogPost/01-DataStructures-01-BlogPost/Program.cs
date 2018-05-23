using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataStructures_01_BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogPost loermIpsum = new BlogPost();
            loermIpsum.AuthorName= "John Doe";
            loermIpsum.Title = "Lorem Ipsum";
            loermIpsum.Text= "Lorem ipsum dolor sit amet.";
            loermIpsum.PublicationDate= "2000.05.04.";

            BlogPost waitButWhy = new BlogPost();
            waitButWhy.AuthorName = "Tim Urban";
            waitButWhy.Title = "Wait but why";
            waitButWhy.Text = "A popular long-form, stick - figure - illustrated blog about almost everything.";
            waitButWhy.PublicationDate = "2010.10.10.";

            BlogPost oneEngineer = new BlogPost();
            oneEngineer.AuthorName = "William Turton";
            oneEngineer.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            oneEngineer.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.";
            oneEngineer.PublicationDate = "2017.03.28.";

            Console.ReadKey();
        }
    }
}
