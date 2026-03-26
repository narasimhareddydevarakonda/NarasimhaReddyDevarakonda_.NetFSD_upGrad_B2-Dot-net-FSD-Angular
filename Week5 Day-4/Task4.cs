using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Day_4
{
    internal class Task4
    {
        static void Main()
        {
            Console.WriteLine("Enter root directory path:");
            string rootpath = Console.ReadLine();
            try
            {
                //check if directory exists
                if (!Directory.Exists(rootpath))
                {
                    Console.WriteLine("Invalid directory path!");
                    return;
                }
                //create directoryinfo object
                DirectoryInfo dirInfo = new DirectoryInfo(rootpath);
                //get all sub directories
                DirectoryInfo[] subDirs = dirInfo.GetDirectories();
                Console.WriteLine("\nsubdirectories and files count:");

                foreach (DirectoryInfo subDir in subDirs)
                {
                    //get files in each subdirectory
                    FileInfo[] files = subDir.GetFiles();

                    Console.WriteLine("Folder Name:" + subDir.Name);
                    Console.WriteLine("Number of Files:" + files.Length);
                    Console.WriteLine("---------------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
    }
}
