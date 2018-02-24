using System;
using System.Collections.Generic;
using Aula21_10_2017.Models;
using Xamarin.Forms;

namespace Aula21_10_2017
{
    public partial class Detalhe : ContentPage
    {
        public Detalhe(Anuncio anuncio)
        {
            BindingContext = anuncio;
            InitializeComponent();
        }
    }
}
