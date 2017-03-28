using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectFolha.View.ReciboDePagamento
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReciboDePagamentoLista : ContentPage
    {
        public ReciboDePagamentoLista()
        {
            InitializeComponent();

            Button1.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new ReciboDePagamentoDetail());
            };
        }
    }
}
