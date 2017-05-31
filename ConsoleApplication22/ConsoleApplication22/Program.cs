using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            FileWatcher fw = new FileWatcher("ControlTask.xt");
            fw.FileChange();
        }
    }
}
