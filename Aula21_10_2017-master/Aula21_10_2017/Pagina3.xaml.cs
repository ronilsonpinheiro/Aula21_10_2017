using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Aula21_10_2017
{
    public partial class Pagina3 : ContentPage
    {
        public Pagina3()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Pagina4());
        }
    }
}
