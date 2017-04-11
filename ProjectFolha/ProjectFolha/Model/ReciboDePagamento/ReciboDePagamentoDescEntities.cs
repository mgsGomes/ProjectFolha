using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.Entities.ReciboDePagamento
{
    public class ReciboDePagamentoDescEntities: ObservableBaseObject
    {
        private string vdb;
        public string Vdb
        {
            get { return vdb; }
            set { vdb = value; OnPropertyChange(); }
        }

        private string descricaoDesc;
        public string DescricaoDesc
        {
            get { return descricaoDesc; }
            set { descricaoDesc = value; OnPropertyChange(); }
        }

        private decimal valorDesc;
        public decimal ValorDesc
        {
            get { return valorDesc; }
            set { valorDesc = value; OnPropertyChange(); }
        }

        public string DescricaoCompletaDesc
        {
            get { return vdb + " - " + descricaoDesc; }
            set { }
        }
    }
}
