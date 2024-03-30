using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DatabaseNasabah.Models
{
    public delegate void PageEventHandler(ContentView page);
    public class PageHandler
    {
        public View Page { get; set; }
    }
}
