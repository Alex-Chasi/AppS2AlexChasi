using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS2AlexChasi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        //agregamos (async) el hilo de conexion entre ventanas
        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            try
            {
                //permite abrir la ventana de notas (MainPage)
                await Navigation.PushAsync(new MainPage());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de Advertencia", ex.Message,"OK");
                //throw;
            }

        }
    }
}