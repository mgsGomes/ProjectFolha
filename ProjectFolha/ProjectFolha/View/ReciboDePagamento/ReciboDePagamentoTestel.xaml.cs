using ProjectFolha.Model.Entities.ReciboDePagamento;
using ProjectFolha.ViewModel.ReciboDePagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
            ReciboDePagamentoDirectoryVM teste = new ReciboDePagamentoDirectoryVM();            


            //var section = new TableSection("Customers");

            //foreach (var customer in teste.RecibosDePagamentos)
            //{          
            //    foreach(var vencimentos in customer.Vencimentos)
            //    {
            //        // populate Data on TableView
            //        var name = vencimentos.Vdb;
            //        var position = vencimentos.DescricaoVencto;

            //        var cell = new TextCell { Text = name, Detail = position };
            //        section.Add(cell);
            //    }             
                
            //}

            //// add the section to the TableView root
            //tbTabela.Root.Add(section);

            //// var table = new TableView();
            //tbTabela.Intent = TableIntent.Settings;
            //var layout = new StackLayout() { Orientation = StackOrientation.Horizontal };
            ////layout.Children.Add(new Image() { Source = "bulb.png" });        



            //layout.Children.Add(new Label()
            //{
            //    Text = "left",
            //    TextColor = Color.FromHex("#f35e20"),
            //    VerticalOptions = LayoutOptions.Center
            //});
            //layout.Children.Add(new Label()
            //{
            //    Text = "right",
            //    TextColor = Color.FromHex("#503026"),
            //    VerticalOptions = LayoutOptions.Center,
            //    HorizontalOptions = LayoutOptions.EndAndExpand
            //});

            //foreach (var lVectoItens in teste.RecibosDePagamentos)
            //{
            //    for (int i = 0; i < lVectoItens.Vencimentos.Count; i++)
            //    {



            //tbTabela.Root = new TableRoot() {
            //    new TableSection("Getting Started") {
            //        new ViewCell() {View = layout}
            //    }
            //};

            //    }
            //}

            // Content = tbTabela;
        }
    }
}
