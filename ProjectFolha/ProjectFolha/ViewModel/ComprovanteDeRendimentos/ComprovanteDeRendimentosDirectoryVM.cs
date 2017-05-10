using ProjectFolha.Model.ComprovanteDeRendimentos;
using ProjectFolha.Model.ComprovanteDeRendimentos.Services;
using ProjectFolha.Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectFolha.ViewModel.ComprovanteDeRendimentos
{
    public class ComprovanteDeRendimentosDirectoryVM: ObservableBaseObject
    {
        public ObservableCollection<ComprovanteDeRendimentosEntities> ComprovanteDeRendimento { get; set; }
        public ObservableCollection<ComprovanteDeRendimentosListaDeContratos> ComprovanteListaDeContratos { get; set; }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChange(); }
        }

        public Command CarregaComprovanteDoFuncionario
        {
            get;
            set;
        }

        public ComprovanteDeRendimentosDirectoryVM()
        {
            ComprovanteDeRendimento = new ObservableCollection<ComprovanteDeRendimentosEntities>();
            ComprovanteListaDeContratos = new ObservableCollection<ComprovanteDeRendimentosListaDeContratos>();

            IsBusy = false;
            CarregaComprovanteDoFuncionario = new Command((obj) => CarregaComprovante());
        }

        async void CarregaComprovante()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var ComprovanteCarregado = ServicoComprovanteRendimentos.CarregaComprovanteDeRendimentos();

                foreach (var comprovante in ComprovanteCarregado.ComprovanteDeRendimentos)
                {
                    ComprovanteDeRendimento.Add(comprovante);
                }


            }

            IsBusy = false;

        }

        public async void CarregaComprovanteLista()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var ComprovanteCarregado = ServicoComprovanteRendimentos.CarregaListaDeContratosPessoaComprovante();

                foreach (var comprovante in ComprovanteCarregado.ComprovanteDeRendimentosListaDeContratos)
                {
                    ComprovanteListaDeContratos.Add(comprovante);
                }
            }

            IsBusy = false;
        }

        public async void CarregaComprovantePorContrato(string unidade, int contrato)
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var ComprovanteCarregado = ServicoComprovanteRendimentos.CarregaComprovantePorContrato(unidade, contrato);

                foreach (var comprovante in ComprovanteCarregado.ComprovanteDeRendimentos)
                {
                    ComprovanteDeRendimento.Add(comprovante);
                }
            }

            IsBusy = false;
        }
    }
}
