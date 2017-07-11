using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectFolha.View.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            string lIdentificadorEmpresa = "9999";
            string lUserName = "Master";
            string lSenha = "123";

            Btn_Logar.Clicked += (sender, e) =>
            {
                if((Edt_IdentificadorEmpresa.Text == lIdentificadorEmpresa) &&
                   (Edt_UserName.Text == lUserName) &&
                   (Edt_Senha.Text == lSenha))
                {
                    Application.Current.MainPage = new MainPage();
                }
                else
                {
                    DisplayAlert("Aviso", "Usuário não cadastrado.", "Ok");
                }
               
            };

        }
    }
}
