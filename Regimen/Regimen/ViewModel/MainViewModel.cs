using Regimen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;
using Xamarin.Forms;

namespace Regimen.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public string CurrentDate => DateTime.Now.ToString("dddd, MMMM d");

        private List<Exercise> _exercises;

        public List<Exercise> Exercises => GetExercises();

        /// <summary>
        /// Get the list of exercises for the current day.
        /// </summary>
        /// <returns>The current day's exercises</returns>
        private List<Exercise> GetExercises()
        {
            if(_exercises == null)
            {
                Assembly assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainViewModel)).Assembly;

                string currentDay = DateTime.Now.DayOfWeek.ToString();
                Stream stream = assembly.GetManifestResourceStream($"Regimen.Exercises.{currentDay}.xml");

                using (StreamReader reader = new StreamReader(stream))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Exercise>));
                    _exercises = (List<Exercise>)serializer.Deserialize(reader);
                }

                foreach(Exercise exercise in _exercises)
                {
                    exercise.Name = exercise.Name.Trim();
                    exercise.Description = exercise.Description.TrimStart();
                    exercise.Description = exercise.Description.TrimEnd();
                    exercise.Routine = exercise.Routine.Trim();
                }
            }

            return _exercises;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
