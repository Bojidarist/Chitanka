using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chitanka
{
    class SpecialPaths
    {
        // Class for "Special" Paths :D
        public static string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string documentsAppFoldier = $@"{ SpecialPaths.documentsPath }\Chitanka Book Downloads";
        public static string xmlPath = $@"{ SpecialPaths.documentsPath }\Chitanka Book Downloads\XML";
        public static string epubPath = $@"{ SpecialPaths.documentsPath }\Chitanka Book Downloads\Epub";



    }
}
