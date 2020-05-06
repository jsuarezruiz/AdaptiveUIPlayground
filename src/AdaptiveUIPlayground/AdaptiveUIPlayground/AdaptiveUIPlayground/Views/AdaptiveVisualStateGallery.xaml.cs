using System;
using Xamarin.Forms;

namespace AdaptiveUIPlayground.Views
{
    public partial class AdaptiveVisualStateGallery : ContentPage
    {
        public AdaptiveVisualStateGallery()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            SizeChanged += OnPageSizeChanged;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            SizeChanged -= OnPageSizeChanged;
        }

        void OnPageSizeChanged(object sender, EventArgs e)
        {
            string visualState = Width > Height ? "Landscape" : "Portrait";

            VisualStateManager.GoToState(MainLayout, visualState);
            VisualStateManager.GoToState(ItemsLayout, visualState);
        }
    }
}
