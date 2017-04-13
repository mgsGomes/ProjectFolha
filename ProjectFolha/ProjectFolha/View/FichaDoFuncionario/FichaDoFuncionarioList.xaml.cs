using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectFolha.ViewModel.FichaDoFuncionario;


namespace ProjectFolha.View.FichaDoFuncionario
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FichaDoFuncionarioLista : ContentPage
    {
        public FichaDoFuncionarioLista()
        {
            InitializeComponent();
            this.BindingContext = new FichaDoFuncionarioDirectoryVM();
            FichaDoFuncionarioDirectoryVM FichaVM = new FichaDoFuncionarioDirectoryVM();

            lvLista.ItemsSource = FichaVM.FichaListaDeContratos;
            FichaVM.CarregaFichaLista();

        }

    }
}
