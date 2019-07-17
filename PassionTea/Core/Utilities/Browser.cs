using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.Core.Utilities
{
    public static class Browser
    {
        public static void GoToUrl(string url)
        {
            SeleniumExecutor.Driver().Navigate().GoToUrl(url);
        }
    }
}
