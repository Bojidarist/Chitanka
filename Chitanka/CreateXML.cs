using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Chitanka
{
    class CreateXML
    {
        public static string xmlLink;
        public static string input;

        public static void Create()
        {

            Console.InputEncoding = Encoding.GetEncoding(1251);
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Getting input
            Console.WriteLine("Type the book's name or type 'Help' or 'Помощ' for help! Type 'Quit', 'Exit' or 'Close' to close the program!");
            input = Console.ReadLine().ToString();

            // Checking for 'help'
            if (input.ToLower() == "help" || input.ToLower() == "помощ")
            {
                RequestHelp.Help();
            }

            //Checking for 'exit' input
            if (input.ToLower() == "quit" || input.ToLower() == "exit" || input.ToLower() == "close")
            {
                Environment.Exit(0);
            }

            //string alternativeInput = File.ReadAllText(@"C:\Users\bojid\Desktop\Projects\Chitanka\ne.txt");

            // Getting XML
            xmlLink = $"https://chitanka.info/books/search.xml?q={ input }";

            WebClient xmlDownload = new WebClient();
            xmlDownload.DownloadFile(xmlLink, $@"{ SpecialPaths.xmlPath }\{ input }.xml");



        }
    }
}
