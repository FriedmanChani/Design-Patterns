// See https://aka.ms/new-console-template for more information
using System;
using Git_Source_Control.Patterns.Observer;
using Git_Source_Control.Repository;
using System.Reflection;
using Git_Source_Control.Models;
using File = Git_Source_Control.Models.File;
using Git_Source_Control.Models.Filestate;

namespace SourceControlSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new Repository("main");
            repo.CreateBranch("feature-1", "main");

            var branch = repo.GetBranch("feature-1");
            var file = new File("file1.cs", "Initial content");
            branch.AddFile(file.Name, file);

            file.ChangeState(new Models.FileState.StagedState());
            file.ChangeState(new Models.FileState.CommittedState());

            var notifier = new ReviewNotifier();
            var reviewer = new Reviewer("Alice");
            notifier.Subscribe(reviewer);

            notifier.Notify(file.Name);

            Console.WriteLine("Done!");
        }
    }
}
