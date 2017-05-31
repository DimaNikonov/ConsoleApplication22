using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{

    class FileWatcher
    {
      
        DateTime timeLast;
        string file;
        public event Action<DateTime> FileChanged; 
        public FileWatcher(string file)
        {
            this.file = file;
        }
        
       public  void FileChange ()
        {
            while(true)
            {
                if(timeLast!=File.GetLastWriteTime(file))
                {
                    timeLast = File.GetLastWriteTime(file);
                    FileChanged?.Invoke(timeLast);
                    Console.WriteLine("File Changed");
                }
            }
        }
         
    }
}
