using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjectFolha.ViewModel.ReciboDePagamento;
using ProjectFolha.Model.Entities.ReciboDePagamento;

namespace ProjectFolha.View.ReciboDePagamento
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReciboDePagamentoLista : ContentPage
    {
        public ReciboDePagamentoLista()
        {
            InitializeComponent();            
            this.BindingContext = new ReciboDePagamentoDirectoryVM();
            ReciboDePagamentoDirectoryVM teste = new ReciboDePagamentoDirectoryVM();            


            lvRecibos.ItemSelected += LvRecibos_ItemSelected;
            Cmb_ListaContratos.SelectedIndexChanged += Cmb_ListaContratos_SelectedIndexChanged;  


            foreach (string unidadeContrato in teste.ListaDeContratosDaPessoa().Keys)
            {
                Cmb_ListaContratos.Items.Add(unidadeContrato);
            }
            Cmb_ListaContratos.SelectedIndex = 0;

            string concatenado = Cmb_ListaContratos.Items[Cmb_ListaContratos.SelectedIndex].ToString();
            string unidade = concatenado.Substring(0, concatenado.IndexOf("/"));
            string contrato = concatenado.Substring(concatenado.IndexOf("/") + 1, (concatenado.IndexOf(" ") - concatenado.IndexOf("/")));

            lvRecibos.ItemsSource = teste.RecibosDePagamentos;
            //teste.CarregaReciboLista();
            teste.CarregaReciboPorContrato(unidade, int.Parse(contrato));

            //foreach(String contrato in teste.)
            //{
            //    ComboBox.Items.Add(contrato);
            //}

            
            //Button1.Clicked += async (sender, e) =>
            //{
            //    await App.NavigateMasterDetail(new ReciboDePagamentoDetail());
            //};
        }


        private void LvRecibos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ReciboDePagamentoEntities selectedRecibo = (ReciboDePagamentoEntities)e.SelectedItem;
            if (selectedRecibo == null)
                return;
            //App.NavigateMasterDetail(new ReciboDePagamentoDetail(selectedRecibo));
           //Navigation.PushAsync(new ReciboDePagamentoDetail(selectedRecibo));
            Navigation.PushAsync(new Page1(selectedRecibo));
            lvRecibos.SelectedItem = null;
        }

        private void Cmb_ListaContratos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReciboDePagamentoDirectoryVM teste = new ReciboDePagamentoDirectoryVM();

            if (Cmb_ListaContratos.Items[Cmb_ListaContratos.SelectedIndex] == null)
                return;

            string concatenado = Cmb_ListaContratos.Items[Cmb_ListaContratos.SelectedIndex].ToString();
            string unidade = concatenado.Substring(0, concatenado.IndexOf("/"));
            string contrato = concatenado.Substring(concatenado.IndexOf("/") + 1, (concatenado.IndexOf(" ") - concatenado.IndexOf("/")));

            teste.CarregaReciboPorContrato(unidade, int.Parse(contrato));
            lvRecibos.ItemsSource = teste.RecibosDePagamentos;
        }
    }
}


