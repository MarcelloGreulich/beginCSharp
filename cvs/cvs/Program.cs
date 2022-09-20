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
            /*FileInfo fi = new FileInfo("T:\\WKH_EXC\\Trash\\cbec\\BMI-data.csv");

            Console.WriteLine("gebe mir den Pfad an");
            string path = Console.ReadLine();

            DirectoryInfo di = new DirectoryInfo(path);

            while (di.Exists==false)
            {
                Console.WriteLine("dein Pfad gibt es nicht gib mir einen anderen");
                path = Console.ReadLine();
                path = path.Replace("\\", "\\\\");
                di = new DirectoryInfo(path);
            }

            Console.WriteLine("Wie soll die dei heißen");
            string filename = Console.ReadLine();
            
            fi.CopyTo(path+ " \\" + filename);*/

            //fi.CopyTo("C:\\010 Projects\\014 begin2\\meinecsv.csv");
            //FileInfo fi_neu = new FileInfo("C:\\010 Projects\\014 begin2\\meinecsv.csv");
            //fi_neu.Delete();
            /*FileInfo fi = new FileInfo("T:\\WKH_EXC\\Trash\\cbec\\BMI-data.csv");

            if (fi.Exists)
            {
                fi.CopyTo("C:\\010 Projects\\014 begin2\\meinecsv.csv");
            }
            Console.ReadLine();*/

            StreamReader sr = new StreamReader("C:\\010 Projects\\014 begin2\\meinecsv.csv");

            List<string[]>eintraege = new List<string[]>();
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                eintraege.Add(sr.ReadLine().Split(';'));
            }

            

            for (int i = 18; i < 101; i++)
            {
                using (StreamWriter sw = new StreamWriter($"C:\\010 Projects\\014 begin2\\Gewichte_{i}.csv"))
                {

                    for (int j = 0; j < eintraege.Count; j++)
                    {
                        if (Convert.ToInt32(eintraege[j][2]) == i)
                        {
                            sw.WriteLine(string.Join(";", eintraege[j]));
                            Console.WriteLine(string.Join("\t", eintraege[j]));
                        }                           
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
