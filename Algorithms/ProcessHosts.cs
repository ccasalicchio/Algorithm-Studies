using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            string line;
            // read the string filename
            string filename = Console.ReadLine();
            string path = string.Format("{0}.txt", filename);
            StreamReader file = new StreamReader(path);
            Dictionary<string, int> log = new Dictionary<string, int>();
            while ((line = file.ReadLine()) != null)
            {
                var recs = line.Split('-');
                string host = recs[0].Trim();
                if (log.ContainsKey(host)) log[host]++;
                else log.Add(host, 1);
            }
            file.Close();
            string[] records = new string[log.Keys.Count];
            string recordsFile = string.Format("records_{0}.txt", filename);


            for (int i = 0; i < log.Keys.Count; i++)
            {
                var item = log.ElementAt(i);
                records[i] = string.Format("{0} {1}", item.Key, item.Value);
            }
            File.WriteAllLines(recordsFile, records);
        }
    }
}