using ProjectFolha.Model.Entities.ReciboDePagamento;
using ProjectFolha.ViewModel.ReciboDePagamento;
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
    public partial class Page1 : TabbedPage
    {
        public Page1(ReciboDePagamentoEntities selectedRecibo)
        {
            InitializeComponent();
            this.BindingContext = selectedRecibo;
            
        }
    }
}
