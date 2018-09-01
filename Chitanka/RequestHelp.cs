using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chitanka
{
    class RequestHelp
    {
        // This is called in the CreateXML class!
        public static void Help()
        {

            // Chitanka Link https://chitanka.info/
            Console.Clear();

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("                                 Help/Помощ");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Type the name of a book you want to download from https://chitanka.info/");
            Console.WriteLine("Въведете името на книга, която искате да изтеглите от https://chitanka.info/");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine($@"The files are located at: { SpecialPaths.documentsAppFoldier }");
            Console.WriteLine($@"Файловете се намират в: { SpecialPaths.documentsAppFoldier }");
            Console.WriteLine("----------------------------------------------------------------------------");

            Console.WriteLine("Press Any Key To Continue . . .");
            Console.ReadKey();

            Console.Clear();
            Bootstrap.StartProgram();



        }
    }
}
