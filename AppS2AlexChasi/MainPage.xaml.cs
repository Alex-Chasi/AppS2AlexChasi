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
        //recibe el usuario pasamos el parametro al metodo
        public MainPage(string usuario)
        {
            InitializeComponent();

            //visualizamos en el label el usuario insertado
            lblUsuario.Text = usuario;
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                //alexchasi prueba de github 

                //comentario2

                //Almacena en variables, lo que el usuario ingresa en las cajas de texto.
                //variables de primera operacion 

                double valor1 = Convert.ToDouble(txtValorUno.Text);
                double valor2 = Convert.ToDouble(txtValorDos.Text);

                //variables de segunda operacion 
                double v1 = Convert.ToDouble(txtV1.Text);
                double v2 = Convert.ToDouble(txtV2.Text);

                if ((valor1 >= 1 && valor1 <= 10) && (valor2 >= 1 && valor2 <= 10) && (v1 >= 1 && v1 <= 10) && (v2 >= 1 && v2 <= 10))
                {
                    //opracion 1 
                    double n1 = valor1 * 0.3;
                    double n2 = valor2 * 0.2;

                    //double suma = valor1 + valor2;
                    double suma = (n1 + n2);

                    //Visualizar el resultado en pantalla.
                    txtResultado.Text = suma.ToString();

                    //Calculo de nota de siguimiento 2
                    //Almacena en variables, lo que el usuario ingresa en las cajas de texto.
                    double np1 = v1 * 0.3;
                    double np2 = v2 * 0.2;

                    //Operacion 2
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
                    else if (sumatot < 5)
                    {
                        DisplayAlert("Reprobado", "Estudiante Reprobado", "OK");

                    }
                }
                else if (valor1 <= 0)
                {
                    DisplayAlert("Ingrese", "Ingrese nota mayor a 0", "OK");

                }
                else if (valor1 > 10)
                {
                    DisplayAlert("Ingrese", "Ingrese nota menor a 10", "OK");

                }
                else if (valor2 <= 0)
                {
                    DisplayAlert("Ingrese", "Ingrese nota mayor a 0", "OK");

                }
                else if (valor2 > 10)
                {
                    DisplayAlert("Ingrese", "Ingrese nota menor a 10", "OK");
                }
                else if (v1 <= 0)
                {
                    DisplayAlert("Ingrese", "Ingrese nota mayor a 0", "OK");

                }
                else if (v1 > 10)
                {
                    DisplayAlert("Ingrese", "Ingrese nota menor a 10", "OK");

                }
                else if (v2 <= 0)
                {
                    DisplayAlert("Ingrese", "Ingrese nota mayor a 0", "OK");

                }
                else if (v2 > 10)
                {
                    DisplayAlert("Ingrese", "Ingrese nota menor a 10", "OK");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", ex.Message, "Ok");
            }
        }
    }
}