using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.Core.Utilities
{
    public static class FileHelper
    {
        public static string GetScreenshotPath()
        {
            var requiredPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));
            requiredPath = requiredPath.Replace("file:\\", string.Empty);
            requiredPath = Path.Combine(requiredPath, "Screenshot");
            if(!Directory.Exists(requiredPath))
            {
                Directory.CreateDirectory(requiredPath);
            }
            requiredPath += @"\";
            return requiredPath;
        }
        public static void DeleteScreenshotFolder()
        {
            var requiredPath = GetScreenshotPath();
            if(Directory.Exists(requiredPath))
            {
                Directory.Delete(requiredPath, true);
            }
        }
    }
}
