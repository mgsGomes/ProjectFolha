using System.Collections.ObjectModel;

namespace ProjectFolha.Model.Entities.ReciboDePagamento
{
    public class ReciboDePagamentoList: ObservableBaseObject
    {
        private ObservableCollection<ReciboDePagamentoEntities> reciboDePagamentoEntities = new ObservableCollection<ReciboDePagamentoEntities>();
        public ObservableCollection<ReciboDePagamentoEntities> ReciboDePagamentoEntities
        {
            get { return reciboDePagamentoEntities; }
            set { reciboDePagamentoEntities = value; }
        }

        private ObservableCollection<ReciboDePagamentoListaDeContratos> reciboDePagamentoListaDeContratos = new ObservableCollection<ReciboDePagamentoListaDeContratos>();
        public ObservableCollection<ReciboDePagamentoListaDeContratos> ReciboDePagamentoListaDeContratos
        {
            get { return reciboDePagamentoListaDeContratos; }
            set { reciboDePagamentoListaDeContratos = value; }
        }
    }
}
