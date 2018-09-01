
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Chitanka
{
    class DownloadByID
    {
        public static void Download()
        {

            Console.InputEncoding = Encoding.GetEncoding(1251);
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CreateXML.Create();
            FindID.Find();


            WebClient downloader = new WebClient();
            downloader.DownloadFile(FindID.link, $@"{ SpecialPaths.epubPath }\{CreateXML.input}.epub");

            Console.Clear();
            Console.WriteLine($@"Downloaded!");
            Console.WriteLine($@"Path: { SpecialPaths.epubPath }\{CreateXML.input}.epub");


        }
    }
}
