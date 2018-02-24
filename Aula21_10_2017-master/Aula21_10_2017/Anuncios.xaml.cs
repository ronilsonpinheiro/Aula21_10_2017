using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Aula21_10_2017.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Aula21_10_2017
{
    public partial class Anuncios : ContentPage
    {
        public ObservableCollection<Anuncio> Dados { get; set; }

        public Anuncios()
        {
            //construtor / jamel coloque código pesado aqui
            BindingContext = this;

            Dados = new ObservableCollection<Anuncio>();
            //Dados.Add(new Anuncio() { Titulo = "Vendo AP" });
            //Dados.Add(new Anuncio() { Titulo = "Vendo Queijo"});

            InitializeComponent();
        }

        // evento disparado quando a tela está carregada
        protected override void OnAppearing()
        {
            CarregaDados();
        }

        async Task CarregaDados()
        {
            var url = "https://classidiario.odiario.com/api/busca/?busca=";

            var web = new HttpClient();
            var json = await web.GetStringAsync(url);

            var anuncios = JsonConvert.DeserializeObject<List<Anuncio>>(json);

            foreach (var anuncio in anuncios)
            {
                Dados.Add(anuncio);
            }
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var anuncio = e.SelectedItem as Anuncio;

            Application.Current.MainPage.Navigation.PushAsync(new Detalhe(anuncio)); 
        }


    }
}
