using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Aula21_10_2017
{
    public partial class Pagina2 : ContentPage
    {
        public Pagina2()
        {
            //Title = "";
            
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Pagina3());
        }
    }
}
