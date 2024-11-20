using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Git_Source_Control.Patterns.Observer
{
        public class ReviewNotifier
        {
            private readonly List<IReviewer> _reviewers = new();

            public void Subscribe(IReviewer reviewer) => _reviewers.Add(reviewer);

            public void Unsubscribe(IReviewer reviewer) => _reviewers.Remove(reviewer);

            public void Notify(string fileName)
            {
                foreach (var reviewer in _reviewers)
                    reviewer.ReviewRequested(fileName);
            }
        }

        

        
}
