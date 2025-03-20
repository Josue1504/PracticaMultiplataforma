using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        double cm;
        double m;

        public Convertir()
        {
            InitializeComponent();
        }
        private void Calcular()
        {
            cm = Convert.ToDouble(Txt_Cm.Text);
            m = cm / 100;
            Lbl_resultado.Text = m.ToString() + "m";
        }
        private void Validar()
        {
            if (!string.IsNullOrEmpty(Txt_Cm.Text))
            {
                Calcular();
            }
            else
            {
                DisplayAlert("Error", "Ingrese una cantidad", "OK");
            }
        }

        private void Btn_volver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Btn_Calcular_Clicked(object sender, EventArgs e)
        {
            Validar(); 
        }
    }
}