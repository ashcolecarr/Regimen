using Regimen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Regimen.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public string TitleWithCurrentDate => $"Exercise Regimen for {DateTime.Now.ToString("dddd, MMMM d")}";

        public List<Exercise> Exercises
        {
            get
            {
                List<Exercise> exercises = new List<Exercise>();
                exercises.Add(new Exercise
                {
                    Name = "Running",
                    Description = "Move rapidly.",
                    Routine = "A lot"
                });
                exercises.Add(new Exercise
                {
                    Name = "Jumping",
                    Description = "Leap high.",
                    Routine = "A few"
                });
                return exercises;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
