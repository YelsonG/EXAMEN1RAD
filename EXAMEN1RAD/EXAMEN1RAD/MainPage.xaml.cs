using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace EXAMEN1RAD
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var paislist = new List<string>();
            paislist.Add("Honduras");
            paislist.Add("Estados Unidos");
            paislist.Add("Guatemala");
            paislist.Add("Mexico");
            paislist.Add("Colombia");

            picker.ItemsSource = paislist;
        }


    }
}
