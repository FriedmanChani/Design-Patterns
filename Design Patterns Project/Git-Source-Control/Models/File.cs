using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Git_Source_Control.Models.Filestate;
using System.IO;

namespace Git_Source_Control.Models
{
        public class File
        {
            public string Name { get; set; }
            public string Content { get; set; }
            public IFileState State { get; set; }
            public List<string> History { get; set; } = new();
        

        public File(string name, string content)
            {
                Name = name;
                Content = content;
                State = new DraftState();
            }
        


        public void ChangeState(IFileState newState)
            {
                if (State.CanTransitionTo(newState))
                {
                    State = newState;
                    History.Add($"State changed to: {State.GetType().Name}");
                }
                else
                {
                    throw new InvalidOperationException($"Cannot transition from {State.GetType().Name} to {newState.GetType().Name}.");
                }
            }

        internal void ChangeState(CommittedState committedState)
        {
            throw new NotImplementedException();
        }
    }
}
