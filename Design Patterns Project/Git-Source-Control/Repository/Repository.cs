using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Git_Source_Control.Models;

namespace Git_Source_Control.Repository
{
        public class Repository
        {
            public Dictionary<string, Branch> Branches { get; set; } = new();
            public Branch MainBranch { get; private set; }

            public Repository(string mainBranchName)
            {
                MainBranch = new Branch(mainBranchName);
                Branches[mainBranchName] = MainBranch;
            }

            public void CreateBranch(string newBranchName, string fromBranchName)
            {
                if (!Branches.ContainsKey(fromBranchName))
                    throw new ArgumentException($"Branch '{fromBranchName}' does not exist.");

                Branches[newBranchName] = new Branch(newBranchName, fromBranchName);
            }

            public void DeleteBranch(string branchName)
            {
                if (branchName == MainBranch.Name)
                    throw new InvalidOperationException("Cannot delete the main branch.");

                Branches.Remove(branchName);
            }

            public Branch GetBranch(string branchName) =>
                Branches.ContainsKey(branchName) ? Branches[branchName] : null;
        }
}
