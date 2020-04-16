using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo info = new DirectoryInfo(@"F:/Filme");
            long MarDir = SOD(info, true);
            Console.WriteLine("Marimea Folderului : " +
            "{0:N0} Bytes", MarDir);
            
            Console.ReadLine();
            Console.ReadKey();
        }
        static long SOD(DirectoryInfo info, bool b)
        {
            long MarTot = info.EnumerateFiles()
                         .Sum(file => file.Length);
            if (b)
            {
                MarTot += info.EnumerateDirectories()
                         .Sum(dir => SOD(dir, true));
            }
            return MarTot;
        }
    }
}

