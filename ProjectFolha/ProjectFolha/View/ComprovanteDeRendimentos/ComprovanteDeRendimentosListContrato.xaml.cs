using ProjectFolha.Model.ComprovanteDeRendimentos;
using ProjectFolha.ViewModel.ComprovanteDeRendimentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectFolha.View.ComprovanteDeRendimentos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComprovanteDeRendimentosListContrato : ContentPage
    {
        public ComprovanteDeRendimentosListContrato()
        {
            InitializeComponent();
            this.BindingContext = new ComprovanteDeRendimentosDirectoryVM();
            ComprovanteDeRendimentosDirectoryVM ComprovanteVM = new ComprovanteDeRendimentosDirectoryVM();

            lvLista.ItemSelected += LvLista_ItemSelected;
            lvLista.ItemsSource = ComprovanteVM.ComprovanteListaDeContratos;
            ComprovanteVM.CarregaComprovanteLista();
        }

        private void LvLista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ComprovanteDeRendimentosListaDeContratos selectedComprovante = (ComprovanteDeRendimentosListaDeContratos)e.SelectedItem;
            ComprovanteDeRendimentosDirectoryVM comprovanteRendimento = new ComprovanteDeRendimentosDirectoryVM();

            if (selectedComprovante == null)
                return;


            comprovanteRendimento.CarregaComprovantePorContrato(selectedComprovante.Unidade, selectedComprovante.Contrato);

            Navigation.PushAsync(new ComprovanteDeRendimentosDetail(comprovanteRendimento));
            lvLista.SelectedItem = null;
        }
    }
}
