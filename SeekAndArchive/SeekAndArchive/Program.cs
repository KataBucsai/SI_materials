using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAndArchive
{
    class Program
    {
        static List<FileInfo> FoundFiles;
        static List<FileSystemWatcher> watchers;
        static private string fileName;
        static private DirectoryInfo rootDir;

        static void Main(string[] args)
        {
            fileName = args[0];
            string directoryName = args[1];
            FoundFiles = new List<FileInfo>();
            watchers = new List<FileSystemWatcher>();

            //examine if the given directory exists at all 
            rootDir = new DirectoryInfo(directoryName);
            if (!rootDir.Exists)
            {
                Console.WriteLine("The specified directory does not exist.");
                return;
            }

            InitFilewatcher();

        }

        private static void InitFilewatcher()
        {
            FoundFiles.Clear();
            //search recursively for the mathing files
            RecursiveSearch(FoundFiles, fileName, rootDir);
            //list the found files
            Console.WriteLine("Found {0} files.", FoundFiles.Count);
            foreach (FileInfo fil in FoundFiles)
            {
                Console.WriteLine("{0}", fil.FullName);
            }

            Console.ReadLine();
        }

        static void RecursiveSearch(List<FileInfo> foundFiles, string fileName, DirectoryInfo currentDirectory)
        {
            foreach (var fil in currentDirectory.GetFiles(fileName))
            {
                foundFiles.Add(fil);
                FileSystemWatcher newWatcher = new FileSystemWatcher(fil.DirectoryName, fil.Name);
                newWatcher.Changed += new FileSystemEventHandler(WatcherChanged);
                newWatcher.Deleted += new FileSystemEventHandler(WatcherDeleted);
                newWatcher.Renamed += new RenamedEventHandler(WatcherRenamed);
                newWatcher.EnableRaisingEvents = true;
                watchers.Add(newWatcher);
            }
            foreach (DirectoryInfo dir in currentDirectory.GetDirectories())
            {
                RecursiveSearch(foundFiles, fileName, dir);
            }
        }

        private static void WatcherRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("{0} renamed to {1}", e.OldFullPath, e.FullPath);
            InitFilewatcher();
        }

        private static void WatcherDeleted(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Deleted)
                Console.WriteLine("{0} has been deleted!", e.FullPath);
                InitFilewatcher();
        }

        static void WatcherChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Changed)
                Console.WriteLine("{0} has been changed!", e.FullPath);
        }

    }
}
