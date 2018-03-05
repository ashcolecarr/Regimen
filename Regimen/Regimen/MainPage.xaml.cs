using Regimen.Model;
using Regimen.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Regimen
{
	public partial class MainPage : ContentPage
	{
        ObservableCollection<Exercise> exercises = new ObservableCollection<Exercise>();

        public MainPage()
		{
			InitializeComponent();

            BindingContext = new MainViewModel();
		}
	}
}
