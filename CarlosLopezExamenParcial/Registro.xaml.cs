using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarlosLopezExamenParcial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string nombredeusuario = "";
        double pagototal = 0;

        public Registro(string usuario, string clave)
        {
            InitializeComponent();
            lblUser.Text = usuario;
            lblPass.Text = clave = "********";
            this.nombredeusuario = usuario;

        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double costoporcurso = 1800;
            double pagoinicial = Double.Parse(txtPagoInicial.Text);

            double mensual = (costoporcurso * 0.05) + ((costoporcurso - pagoinicial) / 3);
            this.pagototal = mensual * 3;
            lblPagoMensual.Text = mensual.ToString();

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombreusuario = txtNombreUser.Text;

            await DisplayAlert("Aviso","Elemento guardado con exito", "OK");
            await Navigation.PushAsync(new Resumen(nombreusuario, this.nombredeusuario, this.pagototal));

        }
    }
}