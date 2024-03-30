using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseNasabah.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DatabaseNasabah
{
    public partial class MainPage : ContentPage
    {
        public event PageEventHandler ChangeMainPage;

        // singleton instance
        private static MainPage instance;
        public static MainPage GetInstance
        {
            get
            {
                if (instance == null)
                {
                    var widhtScreen = 0;
                    var heightScreen = 0;
                    if (Device.RuntimePlatform == Device.Android)
                    {
                        widhtScreen = (int)(
                            DeviceDisplay.MainDisplayInfo.Width
                            / DeviceDisplay.MainDisplayInfo.Density
                        );
                        heightScreen = (int)(
                            DeviceDisplay.MainDisplayInfo.Height
                            / DeviceDisplay.MainDisplayInfo.Density
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
                    instance = new MainPage(widhtScreen, heightScreen);
                }
                return instance;
            }
        }

        public MainPage(int width, int height)
        {
            InitializeComponent();
            ChangeMainPage += OnChangeMainPage;
            MainFrame.WidthRequest = width;
            MainFrame.HeightRequest = height;
            ChangeMainPage(new Views.MenuView());
        }

        public void OnChangeMainPage(ContentView page)
        {
            // cek apakah page di inisiasi dengan 'new' atau tidak
            if (page != null)
            {
                // chek the page type
                MainFrame.Content = page;
            }
            else
            {
                throw new Exception("Page is null");
            }
        }
    }
}
