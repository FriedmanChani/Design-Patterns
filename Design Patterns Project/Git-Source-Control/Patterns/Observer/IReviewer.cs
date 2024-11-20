﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Source_Control.Patterns.Observer
{
    public interface IReviewer
    {
        void ReviewRequested(string fileName);
    }
}