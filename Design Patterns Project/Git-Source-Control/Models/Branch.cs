using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Source_Control.Models
{
    
        public class Branch
        {
            public string Name { get; set; }
            public Dictionary<string, File> Files { get; set; } = new();
            public string ParentBranchName { get; set; }

            public Branch(string name, string parentBranchName = null)
            {
                Name = name;
                ParentBranchName = parentBranchName;
            }

            public void AddFile(string fileName, File file) => Files[fileName] = file;

            public void RemoveFile(string fileName) => Files.Remove(fileName);

            public File GetFile(string fileName) => Files.ContainsKey(fileName) ? Files[fileName] : null;
        }
}
