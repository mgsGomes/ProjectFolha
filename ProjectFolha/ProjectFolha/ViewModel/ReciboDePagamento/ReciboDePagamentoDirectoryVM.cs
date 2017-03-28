using ProjectFolha.Model.Entities.ReciboDePagamento;
using ProjectFolha.Model.Services.ReciboDePagamento;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectFolha.ViewModel.ReciboDePagamento
{
    public class ReciboDePagamentoDirectoryVM
    {
        public ObservableCollection<ReciboDePagamentoEntities> RecibosDePagamentos { get; set; }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; }
        }

        public Command CarregaReciboDePagamento
        {
            get;
            set;
        }

        public ReciboDePagamentoDirectoryVM()
        {
            RecibosDePagamentos = new ObservableCollection<ReciboDePagamentoEntities>();
            IsBusy = false;
            CarregaReciboDePagamento = new Command((obj) => CarregaRecibo());
        }

        async void CarregaRecibo()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var ReciboCarregado = GeraDadosAleatorioTeste.CarregaReciboTeste();

                foreach(var recibo in ReciboCarregado.ReciboDePagamentoEntities)
                {
                    RecibosDePagamentos.Add(recibo);
                }
            }

            IsBusy = false;
        }
    }
}
