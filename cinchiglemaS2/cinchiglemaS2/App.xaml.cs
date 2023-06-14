using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cinchiglemaS2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //comentario de prueba 
            MainPage = new ejercicio();
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
