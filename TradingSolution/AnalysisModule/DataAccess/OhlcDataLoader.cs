using AnalysisModule.Models;
using Core.Abstractions;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysisModule.DataAccess
{
    public class OhlcDataLoader : Loader, ILoader<OhlcFile>
    {
        public OhlcDataLoader() : base("ohlcdata", "*.csv")
        {

        }

        public IEnumerable<OhlcFile> LoadData()
        {
            var res = new List<OhlcFile>();

            foreach(var file in GetFiles())
            {
                res.Add(new OhlcFile
                {
                    FileName = file,
                    Lines = File.ReadAllLines(file).ToList(),
                    Name = GetNameFromPath(file)
                });
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
