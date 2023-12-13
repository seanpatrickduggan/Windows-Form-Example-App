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

        public Task ProcessFiles(IProgress<Tuple<int, string>> progress)
        {
            return Task.Run(() =>
            {
                var files = Directory.GetFiles(selectedFolder, "*.*", SearchOption.AllDirectories);
                var numFiles = files.Length;
                var fileCounter = 0;
                var logFileFolder = Path.Combine(selectedFolder, "log");
                foreach (var file in files)
                {
                    fileCounter++;
                    var fileReport = file.Replace(selectedFolder, "");
                    var progresReport = fileCounter * 100 / numFiles;
                    progress.Report(new Tuple<int, string>(progresReport, fileReport));
                    System.Threading.Thread.Sleep(10); // sleep to simulate processing time
                }
            });
        }
    }
}
