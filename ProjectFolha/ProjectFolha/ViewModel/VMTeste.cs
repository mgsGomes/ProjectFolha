using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppServiceHelpers.Forms;
using ProjectFolha.Model.Entities;
using AppServiceHelpers.Abstractions;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.ComponentModel;

namespace ProjectFolha.ViewModel
{
    public class VMTeste : INotifyPropertyChanged
    {
        //public VMTeste(IEasyMobileServiceClient client) : base(client) { }
        //public TodoItemsViewModel(IEasyMobileServiceClient client) : base (client) { }

        public event PropertyChangedEventHandler PropertyChanged;

        private bool Busy;
        public ObservableCollection<RHEstadoCivil> RhEstadoCivil { get; set; }

        public async Task<List<RHEstadoCivil>> GetEstadoCivil()
        {
            var Service = new Services.AzureServices<RHEstadoCivil>();
            var Items = await Service.GetTable();
            return Items.ToList();
        }

        public bool IsBusy
        {
            get
            {
                return Busy;
            }
            set
            {
                Busy = value;
                OnPropertyChanged();
                GetRHEstadoCivilCommand.ChangeCanExecute();
            }
        }

        public VMTeste()
        {
            RhEstadoCivil = new ObservableCollection<RHEstadoCivil>();

            GetRHEstadoCivilCommand = new Command(
                    async () => await GetRHEstadoCivil(),
                    () => !IsBusy
                );
        }

        async Task GetRHEstadoCivil()
        {
            if (!IsBusy)
            {
                Exception Error = null;
                try
                {
                    IsBusy = true;
                    var Repository = new Repository();
                    var Items = await Repository.GetEstadoCivil();
                    RhEstadoCivil.Clear();
                    foreach (var Cat in Items)
                    {
                        RhEstadoCivil.Add(Cat);
                    }
                }
                catch (Exception ex)
                {
                    Error = ex;
                }
                finally
                {
                    IsBusy = false;

                }

                if (Error != null)
                {
                    await Xamarin.Forms.Application.Current.MainPage.DisplayAlert(
                    "Error!", Error.Message, "OK");
                }

            }
            return;
        }

        public Command GetRHEstadoCivilCommand { get; set; }

        private void OnPropertyChanged(
            [System.Runtime.CompilerServices.CallerMemberName]
            string propertyName = null) =>
            PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(propertyName));
    }
}
    
   
