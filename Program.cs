using System;
using Alphaleonis.Win32.Filesystem;

namespace FileGrabber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write path for logs: ");
            string path = Console.ReadLine();

            string[] directories = Directory.GetDirectories(Path.GetFullPath(path));

            foreach (string directory in directories)
            {
                string targetDirectory = Path.Combine(directory, "FileGrabber");

                if (Directory.Exists(targetDirectory))
                {
                    Directory.Delete(targetDirectory, true, true);
                    Console.WriteLine("Folder " + directory + " Deleted.");
                }
            }
        }

    }
}
