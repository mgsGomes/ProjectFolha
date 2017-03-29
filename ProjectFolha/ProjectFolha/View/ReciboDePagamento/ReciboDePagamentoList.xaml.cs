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
            
            lvRecibos.ItemSelected += LvRecibos_ItemSelected;


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
            Navigation.PushAsync(new ReciboDePagamentoDetail(selectedRecibo));
            lvRecibos.SelectedItem = null;
        }
    }
}
