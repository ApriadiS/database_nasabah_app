using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatabaseNasabah
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // cek device platform
            var widhtScreen = 0;
            var heightScreen = 0;
            if (Device.RuntimePlatform == Device.Android)
            {
                widhtScreen = (int)(
                    DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density
                );
                heightScreen = (int)(
                    DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density
                );
            }
            else if (Device.RuntimePlatform == Device.iOS)
            {
                widhtScreen = (int)DeviceDisplay.MainDisplayInfo.Width;
                heightScreen = (int)DeviceDisplay.MainDisplayInfo.Height;
            }
            else
            {
                widhtScreen = 800;
                heightScreen = 800;
            }
            MainPage = DatabaseNasabah.MainPage.GetInstance;
        }

        protected override void OnStart() { }

        protected override void OnSleep() { }

        protected override void OnResume() { }
    }
}
