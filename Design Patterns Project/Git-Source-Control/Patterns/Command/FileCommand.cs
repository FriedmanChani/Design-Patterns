using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Git_Source_Control.Models;
using File = Git_Source_Control.Models.File;

namespace Git_Source_Control.Patterns.Command
{
        public class FileCommand : ICommand
        {
            private readonly File _file;
            private readonly string _previousContent;
            private readonly string _newContent;

            public FileCommand(File file, string newContent)
            {
                _file = file;
                _previousContent = file.Content;
                _newContent = newContent;
            }

            public void Execute()
            {
                _file.Content = _newContent;
                _file.History.Add($"Content updated to: {_newContent}");
            }

            public void Undo()
            {
                _file.Content = _previousContent;
                _file.History.Add($"Content reverted to: {_previousContent}");
            }
        }
}
