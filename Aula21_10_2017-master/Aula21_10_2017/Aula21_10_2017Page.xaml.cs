using Xamarin.Forms;

namespace Aula21_10_2017
{
    public partial class Aula21_10_2017Page : ContentPage
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        
        public Aula21_10_2017Page()
        {
            Login = "Admin";
            Senha = "Admin";

            BindingContext = this; //todo mudar pra ViewModel
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //var btn = (Button)sender;
            //DisplayAlert("Clicou!", "Você clicou em " + btn.Text, "ok");
            //Navigation.PushModalAsync(new Pagina2());

            if (Login != "Admin" || Senha != "Admin") {
                DisplayAlert("Erro", "Login ou senha inválidos", "ok");
            } else {
                Application.Current.MainPage = new NavigationPage(new Anuncios());
            }
        }
    }
}
