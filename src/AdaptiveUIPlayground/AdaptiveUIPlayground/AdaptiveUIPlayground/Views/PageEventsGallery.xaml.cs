﻿using System;
using Xamarin.Forms;

namespace AdaptiveUIPlayground.Views
{
    public partial class PageEventsGallery : ContentPage
    {
        const double BigScreen = 1280;

        public PageEventsGallery()
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
            if(Width < BigScreen)
            {

            }

            var isLandscape = Width > Height;

            if(isLandscape)
            {
                OrientationLayout.Orientation = StackOrientation.Horizontal;
            }
            else
            {
                OrientationLayout.Orientation = StackOrientation.Vertical;
            }
        }
    }
}