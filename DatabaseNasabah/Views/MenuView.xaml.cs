using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatabaseNasabah.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : ContentView
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void DataNasabahClicked(object sender, EventArgs e)
        {
            DatabaseNasabah.MainPage.GetInstance.OnChangeMainPage(new DataNasabahView());
        }
    }
}
