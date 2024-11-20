using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Source_Control.Models.Filestate
{
    public class DraftState : IFileState
    {
        public DraftState() // Parameterless constructor
        {
            // Initialization code here, if needed
        }

        public bool CanTransitionTo(IFileState newState)
        {
            throw new NotImplementedException();
        }

        // Other methods specific to the DraftState
    }

}
