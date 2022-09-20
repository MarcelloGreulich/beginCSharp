using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cvs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fileShare = new FileStream("C:\\010 Projects\\014 begin2\\csharpfile.txt", FileMode.Append);
            byte[] bdata = Encoding.Default.GetBytes("test ich kann das machen und zwar einfach so!");
            fileShare.Write(bdata, 0, bdata.Length); 
            fileShare.Close();
            Console.WriteLine("Successfully saved file with data : Hello File Handling!");
            Console.ReadKey();
        }
    }
}
