﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ProjectFolha.View.Login;
using AppServiceHelpers.Abstractions;
using AppServiceHelpers;
using ProjectFolha.Model.Entities;

namespace ProjectFolha
{
    public partial class App : Application
    {
        
        public static MasterDetailPage MasterDetail { get; set; }

        public async static Task NavigateMasterDetail(Page page)
        {
            App.MasterDetail.IsPresented = false;
            await App.MasterDetail.Detail.Navigation.PushAsync(page);
        }

        public App()
        {
            InitializeComponent();

            //Página inicial
            //MainPage = new ProjectFolha.MainPage();
            MainPage = new Login();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
