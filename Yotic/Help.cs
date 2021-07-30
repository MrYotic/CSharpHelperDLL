using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yotic
{
    public class Help
    {
        public static void ApplicationBrowse(string link, bool zip)
        {
            new System.Net.WebClient().DownloadFile(link, "" + (zip ? ".zip" : ".exe"));
        }
    }
}
