using Xamarin.Forms;

namespace AdaptiveUIPlayground.Views
{
    public partial class DeviceGallery : ContentPage
    {
        public DeviceGallery()
        {
            InitializeComponent();
            UpdateFontSize();
        }

        void UpdateFontSize()
        {
            if (Device.RuntimePlatform == Device.Android)
                CSharpOnPlarformLabel.FontSize = 12;

            if (Device.RuntimePlatform == Device.iOS)
                CSharpOnPlarformLabel.FontSize = 18;

            if (Device.RuntimePlatform == Device.UWP)
                CSharpOnPlarformLabel.FontSize = 24;

            if(Device.Idiom == TargetIdiom.TV)
                CSharpOnPlarformLabel.FontSize = 28;
        }
    }
}
