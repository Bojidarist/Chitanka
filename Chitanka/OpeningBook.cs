using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chitanka
{
    class OpeningBook
    {
        public static void Open()
        {


            Console.WriteLine("Type 'Open' or 'Отвори' to open the downloaded book! Or Press Enter To Continue . . .");
            string openInput = Console.ReadLine().ToString();

            if (openInput.ToLower() == "open" || openInput.ToLower() == "отвори")
            {
                if (!File.Exists($@"{ SpecialPaths.epubPath }\{CreateXML.input}.epub"))
                {
                    Console.Clear();

                    Console.WriteLine("The file is not found!\nФайлът не е открит!");
                    Console.WriteLine("Press Any Key To Continue . . .");
                    Console.ReadKey();

                    Console.Clear();
                    Bootstrap.StartProgram();
                }

                Process.Start($@"{ SpecialPaths.epubPath }\{CreateXML.input}.epub");
            }
            else
            {
                Console.Clear();
                Bootstrap.StartProgram();
            }


        }
    }
}
