using ProjectFolha.Model.Entities;
using ProjectFolha.Model.Entities.ReciboDePagamento;
using ProjectFolha.Model.Services.ReciboDePagamento;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ProjectFolha.Services;

namespace ProjectFolha.ViewModel.ReciboDePagamento
{
    public class ReciboDePagamentoDirectoryVM: ObservableBaseObject
    {
        public ObservableCollection<ReciboDePagamentoEntities> RecibosDePagamentos { get; set; }
        //public ObservableCollection<ReciboDePagamentoVenctoEntities> ReciboVencimentos { get; set; }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChange(); }
        }

        public Command CarregaReciboDePagamento
        {
            get;
            set;
        }           
            

        public ReciboDePagamentoDirectoryVM()
        {
            RecibosDePagamentos = new ObservableCollection<ReciboDePagamentoEntities>();
           // ReciboVencimentos = new ObservableCollection<ReciboDePagamentoVenctoEntities>();
            IsBusy = false;
            CarregaReciboDePagamento = new Command((obj) => CarregaRecibo());
        }

        async void CarregaRecibo()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var ReciboCarregado = ServicoReciboDePagamento.CarregaRecibo();

                foreach(var recibo in ReciboCarregado.ReciboDePagamentoEntities)
                {
                    RecibosDePagamentos.Add(recibo);
                }

                
            }

            IsBusy = false;
        }

        public async void CarregaReciboLista()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var ReciboCarregado = ServicoReciboDePagamento.CarregaRecibo();

                foreach (var recibo in ReciboCarregado.ReciboDePagamentoEntities)
                {
                    RecibosDePagamentos.Add(recibo);
                }
            }

            IsBusy = false;
        }

        public async void CarregaReciboPorContrato(string unidade, int contrato)
        {
            if(!IsBusy)
            {
                IsBusy = true;

                var ReciboCarregado = ServicoReciboDePagamento.CarregaReciboPorContrato(unidade, contrato);

                foreach(var recibo in ReciboCarregado.ReciboDePagamentoEntities)
                {
                    RecibosDePagamentos.Add(recibo);
                }
            }

            IsBusy = false;
        }

        public Dictionary<String, String> ListaDeContratosDaPessoa()
        {
            Dictionary<String, String> unidadeContrato = new Dictionary<string, string>();

            var ListaDeContratos = ServicoReciboDePagamento.CarregaListaDeContratosPessoa();

            foreach(var listaDeContratosPessoa in ListaDeContratos.ReciboDePagamentoListaDeContratos)
            {
                unidadeContrato.Add(listaDeContratosPessoa.UnidadeContrato, listaDeContratosPessoa.UnidadeContrato);
            }

            return unidadeContrato;
        }

        public async Task<List<ReciboDePagamentoEntities>> GetRecibos()
        {
            var Service = new Services.AzureServices<ReciboDePagamentoEntities>();
            var Items = await Service.GetTable();
            return Items.ToList();
        }
    }
}
