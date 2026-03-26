using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Day_4
{
    internal class Task1
    {
        static void Main()
        {
            Console.WriteLine("Enter your message:");
            string message = Console.ReadLine();
            string filePath = "C:\\Users\\Public\\log.txt";

            try
            {
                //convert string to byte array
                byte[] data = Encoding.UTF8.GetBytes
                    (message + Environment.NewLine);
                //open file in append mode
                using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                {
                    //write data into file
                    fs.Write(data, 0, data.Length);
                }
                Console.WriteLine("Message saved successfully!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while writing to file:" + ex.Message);
            }
        }
    }
}
