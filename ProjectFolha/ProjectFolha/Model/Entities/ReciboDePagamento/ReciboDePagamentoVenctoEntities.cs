using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.Entities.ReciboDePagamento
{
    public class ReciboDePagamentoVenctoEntities: ObservableBaseObject
    {
        private string vdb;
        public string Vdb
        {
            get { return vdb; }
            set { vdb = value; OnPropertyChange(); }
        }

        private string descricaoVencto;
        public string DescricaoVencto
        {
            get { return descricaoVencto; }
            set { descricaoVencto = value; OnPropertyChange(); }
        }

        private decimal valorVencto;
        public decimal ValorVencto
        {
            get { return valorVencto; }
            set { valorVencto = value; OnPropertyChange(); }
        }
    }
}
