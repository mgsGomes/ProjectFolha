using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ProjectFolha.Model.Entities.ReciboDePagamento
{
    public class ReciboDePagamentoListaDeContratos: ObservableBaseObject
    {
        private string unidade;
        public string Unidade
        {
            get { return unidade; }
            set { unidade = value; OnPropertyChange(); }
        }

        private int contrato;
        public int Contrato
        {
            get { return contrato; }
            set { contrato = value; OnPropertyChange(); }
        }

        private string unidadeContrato;
        public string UnidadeContrato
        {
            get { return unidadeContrato; }
            set { unidadeContrato = value; OnPropertyChange(); }
        }
    }
}
