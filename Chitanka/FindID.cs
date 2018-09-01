using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chitanka
{
    class FindID
    {
        public static string link;

        public static void Find()
        {
            Console.InputEncoding = Encoding.GetEncoding(1251);
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            StringBuilder sb = new StringBuilder();
            // For multiple uses
            sb.Remove(0, sb.Length);

            string xml = File.ReadAllText($@"{ SpecialPaths.xmlPath }\{ CreateXML.input }.xml");
            int xmlIndexOfID = xml.IndexOf("id");
            string xmlIDLine = xml.Substring(xmlIndexOfID, 16).ToLower();
            string[] id = xmlIDLine.Split('<', '>');

            for (int i = 0; i < id.Length; i++)
            {

                sb.Append(id[i].Trim(' ', '<', '>', 's', 'l', 'u', 'g', '/', 'i', 'd'));
                //Console.WriteLine(id[i].Trim(' ', '<', '>', 's', 'l', 'u', 'g', '/', 'i', 'd'));



            }

            string bookID = sb.ToString().Trim(' ');
            link = $"https://chitanka.info/book/{ bookID }.epub";
        }
    }
}
