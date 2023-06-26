using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EXAMEN1RAD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageESTUDIANTExaml : ContentPage
    {
        public PageESTUDIANTExaml()

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

        private async void btnGUARDAR_Clicked(object sender, EventArgs e)
        {
            var estudiante = new Models.ESTUDIANTES
            {

                nombres = NOMBRE.Text,
                Apellidos = APELLIDOS.Text,
                EDAD = FECHA.Date,
                telefono = NUMERO.Text,
            };
           
            if( await App.Database.AddEstudiante(estudiante) > 0)
            {
              await  DisplayAlert("AVISO", "USUARION INGRESADO CON EXITO", "OK");
            }
            else
            {
                await DisplayAlert("AVISO", "HA OCURRIDO UN ERROR", "OK");
            }

       
        }
    }
}