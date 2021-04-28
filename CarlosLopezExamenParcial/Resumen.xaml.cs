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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombreusuario, string usuarioconectado, double pagototal)
        {
            InitializeComponent();
            txtnombreusuario.Text = "Nombre usuario: " + nombreusuario;
            txtusuarioconectado.Text = "Usuario conectado: " + usuarioconectado;
            txtPagoFinal.Text = "Valor total a pagar: " + pagototal.ToString();

        }
    }
}