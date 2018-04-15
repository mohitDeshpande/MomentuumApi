using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MomentuumApi.Utils
{
    public class FileHelper
    {
        // Default Set in AppSettings 
       
        private static string basePath;
        private static bool fromDB;

        public static bool FromDB
        {
            get { return fromDB; }
            set { fromDB = value; }
        }

        public static string BasePath
        {
            get { return basePath; }
            set {  basePath=value; }

        }


        
    }
}
