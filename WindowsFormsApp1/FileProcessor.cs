using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormApp
{
    public class FileProcessor
    {

        public List<string> files;
        public List<string> fileNames;
        public string selectedFolder { get; set; }
        public int fileCount
        {
            get { return CountFiles(selectedFolder); }
        }

        public int CountFiles(string folderPath)
        {
            return Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories).Length;
        }

        public Task ProcessFiles(IProgress<int> progress)
        {
            return Task.Run(() =>
            {
                for (int i = 0; i < fileCount; i++)
                {
                    // Simulate file processing time
                    System.Threading.Thread.Sleep(1); // sleep for 50ms

                    // Report progress
                    progress.Report(i + 1);
                }
            });
        }
    }
}
