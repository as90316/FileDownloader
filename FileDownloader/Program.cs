using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello");
                FileDownloaderClass f = new FileDownloaderClass();
                Console.WriteLine("Enter the complete URL: e.g. http://www.africau.edu/images/default/sample.pdf");
                f.URL = Console.ReadLine();
                Console.WriteLine("Enter the file to be saved as? e.g. mypdf.pdf");
                f.DEST = Console.ReadLine();
                f.DownloadAndSave();
                Console.WriteLine("Download completed at " + f.DEST + "   ...Good Bye");
            }
            catch (System.ArgumentNullException e) {
                Console.WriteLine("URL " + e.Message);
                return;
            }
        }
    }
}
