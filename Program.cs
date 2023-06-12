using System;
using System.IO;

namespace FileGrabber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получаем путь из аргументов командной строки
            string path = args[0];

            // Получаем список всех каталогов в пути
            string[] directories = Directory.GetDirectories(path);

            foreach (string directory in directories)
            {
                // Соединяем имя каталога с "FileGrabber"
                string targetDirectory = Path.Combine(directory, "FileGrabber");

                // Проверяем, существует ли такой каталог
                if (Directory.Exists(targetDirectory))
                {
                    // Удаляем каталог со всеми файлами в нем
                    Directory.Delete(targetDirectory, true);
                    Console.WriteLine("Folder " + directory + " Deleted.");
                }
            }
        }
    }
}
