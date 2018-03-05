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
                    Name = "Running"
                });
                exercises.Add(new Exercise
                {
                    Name = "Jumping"
                });

                return exercises;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
