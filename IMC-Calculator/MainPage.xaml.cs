using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IMC_Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e) 
        {
            if (!string.IsNullOrEmpty(Altura.Text) &&
                !string.IsNullOrEmpty(Peso.Text))
            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);

                var imc = peso / (altura * altura);
                IMC.Text = imc.ToString();

                string resultado;
                if (imc < 18.5)
                {
                    resultado = "Tienes peso bajo";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    resultado = "Tienes un peso normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resultado = "Usted tiene sobrepeso";
                }
                else
                {
                    resultado = "Tienes obesidad";
                }

                DisplayAlert("Resultado", resultado, "Ok");
            }
            else
            {
                DisplayAlert("Datos erroneos", "Porfavor, llena la informacion con datos validos.", "Ok");
            }
        }
    }
}
