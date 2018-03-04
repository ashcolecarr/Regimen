using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Regimen.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public string TitleWithCurrentDate => $"Exercise Regimen for {DateTime.Now.ToString("0:dddd, MMMM d")}";

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
