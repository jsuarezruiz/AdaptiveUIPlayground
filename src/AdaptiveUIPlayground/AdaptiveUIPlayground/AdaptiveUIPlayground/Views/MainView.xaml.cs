using System;
using Xamarin.Forms;

namespace AdaptiveUIPlayground.Views
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
        }

        void OnDeviceBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeviceGallery());
        }

        void OnPageEventsBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageEventsGallery());
        }
    }
}