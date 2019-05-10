using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Document_Merger_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string loop = "y";
            while (loop == "y")
            {
                string file1, file2;
                Console.WriteLine("*****DOCUMENT MERGER! THE SEQUEL*****\n\n\nWhat is the name of the first file?");
                file1 = Console.ReadLine();
                while (File.Exists(file1 + ".txt") == false)
                {
                    Console.WriteLine("\nSorry this File couldn't be found. Please try agian!");
                    file1 = Console.ReadLine();
                }
                Console.WriteLine("\nWhat's the name of your second file?");
                file2 = Console.ReadLine();
                while (File.Exists(file2 + ".txt") == false)
                {
                    Console.WriteLine("\nSorry this File couldn't be found. Please try again!");
                    file2 = Console.ReadLine();
                }
                string merege = file1 + file2 + ".txt";
                string file1characters = "";
                string file2characters = "";
                string fileline = "";
                string fileline2 = "";
                int x;

                StreamReader sr = new StreamReader(file1 + ".txt");
                StreamReader dr = new StreamReader(file2 + ".txt");
                StreamWriter dw = new StreamWriter(merege);

                try
                {
                    fileline = sr.ReadLine();
                    file1characters = fileline;
                    while (fileline != null)
                    {
                        fileline = sr.ReadLine();
                        file1characters += fileline;
                        file1characters = file1characters + fileline;
                    }
                    fileline2 = dr.ReadLine();
                    file2characters = fileline2;
                    while (fileline != null)
                    {
                        fileline2 = dr.ReadLine();
                        file2characters += fileline2;
                        file1characters = file1characters + fileline2;
                    }
                    string merge = file1characters + file2characters;
                    dw.Write(merge);
                    x = file1characters.Length + file2characters.Length;
                }
                catch (Exception d)
                {
                    Console.WriteLine("Exception: " + d.Message);
                }
                finally
                {
                    sr.Close();
                    dr.Close();
                    dw.Close();
                }
                Console.WriteLine("\n\nWould you like to merge two more files? if so enter y, if not enter any character");
                loop = Console.ReadLine();
            }
        }
    }
}