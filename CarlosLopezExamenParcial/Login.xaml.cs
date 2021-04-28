﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarlosLopezExamenParcial
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnRegistro_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string clave = txtPass.Text;

            if(usuario != "estudiante2021" | clave != "uisrael2021")
            {
                await DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Cerrar");
                return;
            }
            await Navigation.PushAsync(new Registro(usuario, clave));

        }
    }
}
