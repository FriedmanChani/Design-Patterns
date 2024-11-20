using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Git_Source_Control.Models;
using File = Git_Source_Control.Models.File;

namespace Git_Source_Control.Repository
{
        public class Commit
        {
            public List<File> Files { get; } = new();

            public Commit(List<File> files)
            {
                Files.AddRange(files);
            }

            public void Execute()
            {
                foreach (var file in Files)
                    file.ChangeState(new Models.Filestate.CommittedState());
            }
        }
}
