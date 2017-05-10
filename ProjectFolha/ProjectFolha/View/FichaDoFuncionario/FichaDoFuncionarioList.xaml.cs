using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectFolha.ViewModel.FichaDoFuncionario;
using ProjectFolha.Model.FichaDoFuncionario;

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

            lvLista.ItemSelected += LvLista_ItemSelected;
            lvLista.ItemsSource = FichaVM.FichaListaDeContratos;
            FichaVM.CarregaFichaLista();

        }

        private void LvLista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            FichaDoFuncionarioListaDeContratos selectedFicha = (FichaDoFuncionarioListaDeContratos)e.SelectedItem;
            FichaDoFuncionarioDirectoryVM fichaDoFuncionario = new FichaDoFuncionarioDirectoryVM();

            if (selectedFicha == null)
                return;

            
            fichaDoFuncionario.CarregaFichaPorContrato(selectedFicha.Unidade, selectedFicha.Contrato);           

            Navigation.PushAsync(new FichaDoFuncionarioDetail(fichaDoFuncionario));
            lvLista.SelectedItem = null;
        }
    }
}
