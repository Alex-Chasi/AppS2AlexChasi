using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppS2AlexChasi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Almacena en variables, lo que el usuario ingresa en las cajas de texto.
                double valor1 = Convert.ToDouble(txtValorUno.Text);
                double n1 = valor1 * 0.3;
                double valor2 = Convert.ToDouble(txtValorDos.Text);
                double n2 = valor2 * 0.2;

                //Operacion 
                //double suma = valor1 + valor2;
                double suma = (n1 + n2);

                //Visualizar el resultado en pantalla.
                txtResultado.Text = suma.ToString();

                //Calculo de nota de siguimiento 2
                //Almacena en variables, lo que el usuario ingresa en las cajas de texto.
                double v1 = Convert.ToDouble(txtV1.Text);
                double np1 = v1 * 0.3;
                double v2 = Convert.ToDouble(txtV2.Text);
                double np2 = v2 * 0.2;

                //Operacion 
                //double suma = valor1 + valor2;
                double suma2 = (np1 + np2);

                //Visualizar el resultado en pantalla.
                txtR2.Text = suma2.ToString();

                //resultado final
                double sumatot = suma + suma2;

                //Visualizar el resultado en pantalla.
                txtFinal.Text = sumatot.ToString();

                //validacion de mensaje 
                if (sumatot >= 7)
                {
                    DisplayAlert("Aprobado", "Estudiante Aprobo", "OK");

                }
                else if (sumatot >= 5 && sumatot <= 6.9)
                {
                    DisplayAlert("Complementario", "Estudiante Complementario", "OK");


                }
                else if (sumatot <5)
                {
                    DisplayAlert("Reprobado", "Estudiante Reprobado", "OK");


                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", ex.Message, "Ok");
            } 
        }
    }
}