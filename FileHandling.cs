using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace Algorithm
{
    internal class FileHandling
    {
        public string Path;
        public string Filename;
        public string Folder;
        private string FolderDefault = "FileCreatorDefault";

        public FileHandling(string PathIn, string FilenameIn)
        {
            Path = PathIn;
            Filename = FilenameIn;
        }

        public void FolderCreate()
        {
            Console.WriteLine("Enter the Name of the folder");
            Folder = Console.ReadLine();
            while (Folder == "")
            {
                Folder = FolderDefault;
            }
            if (Directory.Exists(Path + Folder))
            {
                Console.WriteLine("Folder Already exists");
            }
            else
            {
                Directory.CreateDirectory(Path + @"\" + Folder);
                Console.WriteLine("Folder has been created");
            }
        }

        public void FileCreate()
        {
            if (File.Exists(Path + Folder + Filename))
            {
                Console.WriteLine("File Already exists");
            }
            else
            {
                File.Create(Path + @"\" + Folder + @"\" + Filename).Close();
                Console.WriteLine("File has been created");
            }

        }

        public void FileEdit()
        {
            Console.WriteLine("Enter the text you want to enter");
            string Contents = Console.ReadLine();
            if (File.Exists(Path + @"\" + Folder + @"\" + Filename))
            {
                File.WriteAllText(Path + @"\" + Folder + @"\" + Filename, Contents);
            }
            else
            {
                Console.WriteLine("File does not exist");
                FileCreate();
            }
        }

        public void FileRead()
        {
                Console.WriteLine("The text is :\n");
                Console.WriteLine(File.ReadAllText(Path + @"\" + Folder + @"\" + Filename));
        }
    }
}
