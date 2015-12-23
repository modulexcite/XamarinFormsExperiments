using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsExperiments
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void FontSizeChanged(object sender, EventArgs arguments)
        {
            _helloWorldLabel.FontSize = _sizeSlider.Value;
        }
    }
}

