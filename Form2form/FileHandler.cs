using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.NetworkInformation;

namespace Pinger
{
    static class FileHandler
    {
        public static List<string> OpenFile(string filename)
        {    
                StreamReader Reader = new StreamReader(filename);
                List<string> items = new List<string>();
                string temp = "";
                while (temp != null)
                {
                    temp = Reader.ReadLine();
                    if (temp != null)
                    {
                        items.Add(temp);
                    }
                }
                Reader.Close();
                return items;
        }
        public static void SaveFile(List<string> items, string Filename, bool append)
        {
            StreamWriter Writer = new StreamWriter(Filename, append);
            for (int i = 0; i < items.Count; i++)
            {
                Writer.WriteLine(items[i]);
            }
            Writer.Close();
        }
    }
}

