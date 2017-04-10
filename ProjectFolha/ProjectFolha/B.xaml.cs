using AppServiceHelpers.Abstractions;
using Microsoft.WindowsAzure.MobileServices;
using ProjectFolha.Model.Entities;
using ProjectFolha.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectFolha.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ProjectFolha
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class B : ContentPage
    {
        //IMobileServiceClient Client;
        //IMobileServiceTable<RHEstadoCivil> Table;
        //IMobileServiceClient Client;
        //IMobileServiceTable<RHEstadoCivil> Table;
        public B()
        {
            InitializeComponent();
            //string MyAppServiceURL = "http://projectfolha.azurewebsites.net";
            //Client = new MobileServiceClient(MyAppServiceURL);
            //Table = Client.GetTable<RHEstadoCivil>();
            //Task<List<RHEstadoCivil>> Tabela = Table.ToListAsync();


            // BindingContext = new VMTeste(Client);

            //string MyAppServiceURL = "http://projectfolha.azurewebsites.net";

            //Client = new MobileServiceClient(MyAppServiceURL);

            //Table = Client.GetTable<RHEstadoCivil>();

            //Task<List<RHEstadoCivil>> Tabela = Table.ToListAsync();

            //label1.Text = Tabela.Result.First().EstadoCivil;
            //label2.Text = Tabela.Result.First().Descricao20;


        }

        //public Task<IEnumerable<RHEstadoCivil>> GetTable()
        //{
        //    return Table.ToEnumerableAsync();
        //}
    }
}
