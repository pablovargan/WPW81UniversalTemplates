﻿namespace WP81Template.ViewModels
{
    using System.Threading.Tasks;
    using Windows.UI.Xaml.Navigation;
    using WP81Template.ViewModels.Base;

    public class MainViewModel : ViewModelBase
    {
        public override Task OnNavigatedFrom(NavigationEventArgs args)
        {
            return null;
        }

        public override Task OnNavigatingFrom(NavigatingCancelEventArgs args)
        {
            return null;
        }

        public override Task OnNavigatedTo(NavigationEventArgs args)
        {
            return null;
        }

        public MainViewModel()
        {

        }
    }
}
