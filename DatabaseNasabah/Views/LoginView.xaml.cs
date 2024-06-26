﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseNasabah;
using DatabaseNasabah.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatabaseNasabah.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginClicked(object sender, EventArgs e)
        {
            DatabaseNasabah.MainPage.GetInstance.OnChangeMainPage(new MenuView());
        }
    }
}
