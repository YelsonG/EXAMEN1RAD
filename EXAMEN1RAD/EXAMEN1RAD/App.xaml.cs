using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EXAMEN1RAD;
using EXAMEN1RAD.CONTROLES;
using System.IO;

namespace EXAMEN1RAD
{
    

    public partial class App : Application
    {
        static DataBase database;

        public static DataBase Database
        {
          get
          {
                var dbpapth = string.Empty;
                var namedb = string.Empty;
                var fullpath = string.Empty;

                dbpapth = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                namedb = "DBESTUDIANTES.db3";
                fullpath = Path.Combine(dbpapth, namedb);

                if (database == null)
                {
                    database = new DataBase();
                }

                return database;
            }  
        }

    public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage ( new Views.PageESTUDIANTExaml());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
