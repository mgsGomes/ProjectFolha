using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.Entities.ReciboDePagamento
{
    public class ReciboDePagamentoBaseEntities: ObservableBaseObject
    {
        private string vdb;
        public string Vdb
        {
            get { return vdb; }
            set { vdb = value; OnPropertyChange(); }
        }

        private string descricaoBase;
        public string DescricaoBase
        {
            get { return descricaoBase; }
            set { descricaoBase = value; OnPropertyChange(); }
        }

        private decimal valorBase;
        public decimal ValorBase
        {
            get { return valorBase; }
            set { valorBase = value; OnPropertyChange(); }
        }
    }
}
