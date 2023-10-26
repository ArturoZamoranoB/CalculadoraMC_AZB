using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraMC_AZB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Peso.Text) && !string.IsNullOrEmpty(Altura.Text)){
                float peso = float.Parse(Peso.Text);
                float altura = float.Parse(Altura.Text);
                float imc = peso / (altura * altura);

                IMC.Text = imc.ToString();
                string Rango = "";

                if (imc < 18.5)
                {
                    Rango = "Tienes bajo peso";


                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    Rango = "Peso Normal";
                }
                else if (imc <= 24.9 && imc >= 29.9)
                {


                }
                else
                {
                    Rango = "Tienes sobre obesida mi apa";

                }
                DisplayAlert("Rango de peso", Rango, "Quitar");
            }
            else
            {
                DisplayAlert("Campos vacios", "Ingresa todos los datos", "quitar");
            }
        }
    }
}
