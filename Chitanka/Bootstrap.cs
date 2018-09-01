using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chitanka
{
    class Bootstrap
    {
        public static void StartProgram()
        {

            Console.InputEncoding = Encoding.GetEncoding(1251);
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Lazy Exception Handling :(
            try
            {

                // Creating a directory to save the files
                CreateDirectory.Create();

                // Downloading necessary files
                DownloadByID.Download();

                // Ask the user to open the latest downloaded book or to continue!
                OpeningBook.Open();
            }           
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Something went wrong maybe you typed a wrong name.");
                Console.WriteLine("Нещо се е объркало, може би сте написали погрешно име.");
                Console.WriteLine("Press Any Key To Continue!");
                Console.ReadKey();
            }
            finally
            {
                if (File.Exists($@"{ SpecialPaths.xmlPath }\{ CreateXML.input }.xml"))
                {
                    File.Delete($@"{ SpecialPaths.xmlPath }\{ CreateXML.input }.xml");
                }
                Console.Clear();
                Bootstrap.StartProgram();
            }

        }
    }
}
