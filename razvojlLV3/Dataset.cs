using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razvojlLV3
{
    class Dataset : IPrototype
    {
        private List<List<string>> data; //list of lists of strings
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public string PrintList()
        {
            
            StringBuilder stringBuilder = new StringBuilder();
            foreach (List<string> item in this.data)
            {
                foreach (var obj in item)
                {              
                    stringBuilder.Append(obj);
                }
                stringBuilder.Append("\n");
            }
            return stringBuilder.ToString();
        }
        public IPrototype Clone()
        {   //u zadatku nije potrebno duboko kopiranje jer je riječ o stringovima
            Dataset clone=(Dataset)this.MemberwiseClone();
            clone.data = new List< List < string >> (this.data.Count);
            foreach(List<string> data in this.data)
            {
                clone.data.Add((List<string>)Clone());
            }
            return clone;
        }
        
    }
}
