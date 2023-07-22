using System;
using System.IO;
namespace RainBowAssociations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           doApp();
        }
        public static void doApp()
        {
            try
            {
                string dir = Directory.GetCurrentDirectory();
                string filename = dir + "\\Student Data.txt";
                if (File.Exists(filename))
                {
                    string[] lines = File.ReadAllLines(filename);
                    Console.WriteLine("The content in the file is as follows:");
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine($"{filename} is not found in these location");
                }
            }
            catch(FileNotFoundException fe)
            {
                Console.WriteLine("File not Found Error !!! "+fe.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error !!!"+e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
           
        }

    }
}
