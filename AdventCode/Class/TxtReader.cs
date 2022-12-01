using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode.Class
{
    internal class TxtReader
    {
        private string _path;

        public TxtReader(string path)
        {
            UpdatePath(path);
        }

        public void UpdatePath(string path)
        {
            _path = path;  
        }
        public List<string> ReturnInput()
        {
            List<string> result = new List<string>();
            var files = File.ReadAllLines(_path);
            foreach (var line in files)
            {
                result.Add(line);
            }
            return result;
        }
    }
}
