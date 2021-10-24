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
    public partial class viewDos : ContentPage
    {
        public viewDos()
        {
            InitializeComponent();
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Almacena en variables, lo que el usuario ingresa en las cajas de texto.
                double valor1 = Convert.ToDouble(txtValorUno.Text);
                double valor2 = Convert.ToDouble(txtValorDos.Text);

                //Operacion 
                double suma = valor1 + valor2;

                //Visualizar el resultado en pantalla.
                //txtResultado.Text = "El resultado es " + suma.ToString();

                txtResultado.Text = "El resultado es " + Convert.ToString(suma);


            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", ex.Message, "Ok");
            }
        }
    }
}