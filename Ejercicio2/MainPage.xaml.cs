using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnsalvar_Clicked(object sender, EventArgs e)
        {
            // var mostrar = nombre.Text  + apellido.Text  + edad.Text  + correo.Text;

            //DisplayAlert("Aviso", "sus datos son " + mostrar.ToString(), "OK");

            // Views.PageResultado page = new Views.PageResultado();
            // await Navigation.PushAsync(page);

            var Datos = new Models.Datos
            {
                nombre= nombre.Text,
                apellido=apellido.Text,
                edad=   edad.Text,
                correo= correo.Text,
            };
            Views.PageResultado page = new Views.PageResultado();
            page.BindingContext= Datos;
            await Navigation.PushAsync(page);


        }
    }
}
