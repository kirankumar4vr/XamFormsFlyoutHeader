using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FlyOutHearder.Views
{
    public partial class FlyoutMenuHeader : ContentView
    {
        public FlyoutMenuHeader()
        {
            InitializeComponent();
        }
        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = false;
        }
    }
}
