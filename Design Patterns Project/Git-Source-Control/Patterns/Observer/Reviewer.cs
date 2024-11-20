using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Source_Control.Patterns.Observer
{
    public class Reviewer : IReviewer
    {
        public string Name { get; }

        public Reviewer(string name) => Name = name;

        public void ReviewRequested(string fileName)
        {
            Console.WriteLine($"Reviewer {Name}: Review requested for file '{fileName}'.");
        }
    }
}
