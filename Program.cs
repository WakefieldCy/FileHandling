using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Environment.UserName;
            string Path = @"C:\\Users\\" + username + @"\\OneDrive - Wakefield College\\Documents"; //PathName();
            string FileName = Filename() + ".txt";
            
            FileHandling FileHandle = new FileHandling(Path, FileName);
            //FileHandle.FolderCreate();
            //FileHandle.FileCreate();
            //FileHandle.FileEdit();
            //FileHandle.FileRead();
            
            Console.WriteLine(username);
            Console.ReadKey();
        }
        static string PathName()
        {
            Console.WriteLine("Enter the Path");
            string Path = @Console.ReadLine() + @"\";

            return Path;
        }
        static string Filename()
        {
            Console.WriteLine("Enter the filename");
            string Filename = @Console.ReadLine();
            
            return Filename;
        }
    }
}
