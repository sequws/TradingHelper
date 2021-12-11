using Core.Abstractions;
using Core.Interfaces;
using StatementModule.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementModule.DataAccess
{
    public class StatementLoader : Loader, ILoader<StatementFile>
    {
        public StatementLoader() : base("statements")
        {

        }

        public List<string> GetFiles()
        {
            if (!Directory.Exists(DataFolder))
            {
                return new List<string>();
            }

            string[] files = Directory.GetFiles(DataFolder, extension);

            return files.ToList();
        }

        public IEnumerable<StatementFile> LoadData()
        {
            var res = new List<StatementFile>();

            foreach (var file in GetFiles())
            {
                var name = GetNameFromPath(file);
                var dataLines = File.ReadAllLines(file);
                res.Add(new StatementFile { FileName = file, Lines = dataLines.ToList(), Name = name });
            }

            return res;
        }

        private string GetNameFromPath(string path)
        {
            string name = "NoName";

            var parts = path.Split(new char[] { '/', '\\' }, StringSplitOptions.RemoveEmptyEntries);
            name = parts[parts.Length - 1];
            name = Path.GetFileNameWithoutExtension(name);

            return name;
        }
    }
}
