using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace nexttime.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://github.com/jgonzal10")));
        }

        public ICommand OpenWebCommand { get; }
    }
}