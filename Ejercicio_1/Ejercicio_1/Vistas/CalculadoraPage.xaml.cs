using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio_1.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculadoraPage : ContentPage
    {
        public CalculadoraPage()
        {
            InitializeComponent();
        }

        private void Sumar(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;
            double resultadoSuma = 0;

            // Intenta convertir los valores ingresados en las cajas de texto a números
            bool num1Valido = double.TryParse(PrimerNumero.Text, out num1);
            bool num2Valido = double.TryParse(SegundoNumero.Text, out num2);

            // Si ambos números son válidos, realiza la suma
            if (num1Valido && num2Valido)
            {
                resultadoSuma = num1 + num2;
                ResultadoFinal.Text = resultadoSuma.ToString();
            }
            else
            {
                ResultadoFinal.Text = "Error: Ingresa valores numéricos válidos";
            }
        }

        private void Restar(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;
            double resultadoResta = 0;

            // Intenta convertir los valores ingresados en las cajas de texto a números
            bool num1Valido = double.TryParse(PrimerNumero.Text, out num1);
            bool num2Valido = double.TryParse(SegundoNumero.Text, out num2);

            // Si ambos números son válidos, realiza la suma
            if (num1Valido && num2Valido)
            {
                resultadoResta = num1 - num2;
                ResultadoFinal.Text = resultadoResta.ToString();
            }
            else
            {
                ResultadoFinal.Text = "Error: Ingresa valores numéricos válidos";
            }
        }

        private void Multiplicar(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;
            double resultadoMultiplicar = 0;

            // Intenta convertir los valores ingresados en las cajas de texto a números
            bool num1Valido = double.TryParse(PrimerNumero.Text, out num1);
            bool num2Valido = double.TryParse(SegundoNumero.Text, out num2);

            // Si ambos números son válidos, realiza la suma
            if (num1Valido && num2Valido)
            {
                resultadoMultiplicar = num1 * num2;
                ResultadoFinal.Text = resultadoMultiplicar.ToString();
            }
            else
            {
                ResultadoFinal.Text = "Error: Ingresa valores numéricos válidos";
            }
        }

        private void Dividir(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;
            double resultadoDividir = 0;

            // Intenta convertir los valores ingresados en las cajas de texto a números
            bool num1Valido = double.TryParse(PrimerNumero.Text, out num1);
            bool num2Valido = double.TryParse(SegundoNumero.Text, out num2);

            // Si ambos números son válidos, realiza la suma
            if (num1Valido && num2Valido)
            {
                resultadoDividir = num1 / num2;
                ResultadoFinal.Text = resultadoDividir.ToString();
            }
            else
            {
                ResultadoFinal.Text = "Error: Ingresa valores numéricos válidos";
            }
        }



        private void Limpiar(object sender, EventArgs e)
        {
            PrimerNumero.Text = string.Empty;
            SegundoNumero.Text = string.Empty;
            ResultadoFinal.Text = string.Empty;
        }
    }
}