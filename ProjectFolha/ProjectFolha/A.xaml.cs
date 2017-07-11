using AppServiceHelpers;
using AppServiceHelpers.Abstractions;
using Microsoft.WindowsAzure.MobileServices;
using ProjectFolha.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectFolha
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class A : ContentPage
    {
        //IEasyMobileServiceClient client;
        
        public A()
        {
            InitializeComponent();
            //client = new EasyMobileServiceClient();
            //client.Initialize("http://projectfolha.azurewebsites.net");
            //client.RegisterTable<RHEstadoCivil>();
            //client.FinalizeSchema();



            //Button1.Clicked += async (sender, e) =>
            //{
            //    await App.NavigateMasterDetail(new B());
            //};
        }
    }
}
