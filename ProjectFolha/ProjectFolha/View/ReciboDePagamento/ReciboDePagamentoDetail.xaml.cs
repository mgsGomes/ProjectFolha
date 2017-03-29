using ProjectFolha.Model.Entities.ReciboDePagamento;
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
    public partial class ReciboDePagamentoDetail : ContentPage
    {
        public ReciboDePagamentoDetail(ReciboDePagamentoEntities selectedRecibo)
        {
            InitializeComponent();
            this.BindingContext = selectedRecibo;
        }
    }
}
