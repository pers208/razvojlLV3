using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razvojlLV3
{
    class Logger
    {   //ako nije promijenjen path logger će upisivati na isto mjesto
        private string fileName="csvfile.txt";
        private static Logger instance;
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
        public void SetFileName(string fileName)
        {
            this.fileName = fileName;
        }
        public void LogToFile(string information)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName, true))
            {
                writer.WriteLine(information);
            }
        }
    }
}
