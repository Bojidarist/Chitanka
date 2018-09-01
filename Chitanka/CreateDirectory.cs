using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chitanka
{
    class CreateDirectory
    {
        public static void Create()
        {

            if (!Directory.Exists($@"{ SpecialPaths.documentsPath }\Chitanka Book Downloads"))
            {
                Directory.CreateDirectory($@"{ SpecialPaths.documentsPath }\Chitanka Book Downloads");
            }
            if (!Directory.Exists($@"{ SpecialPaths.documentsPath }\Chitanka Book Downloads\XML"))
            {
                Directory.CreateDirectory($@"{ SpecialPaths.documentsPath }\Chitanka Book Downloads\XML");
            }
            if (!Directory.Exists($@"{ SpecialPaths.documentsPath }\Chitanka Book Downloads\Epub"))
            {
                Directory.CreateDirectory($@"{ SpecialPaths.documentsPath }\Chitanka Book Downloads\Epub");
            }

        }
    }
}
