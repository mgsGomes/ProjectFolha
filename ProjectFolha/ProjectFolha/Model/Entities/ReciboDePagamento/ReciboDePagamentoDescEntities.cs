using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.Entities.ReciboDePagamento
{
    public class ReciboDePagamentoDescEntities
    {
        private string vdb;
        public string Vdb
        {
            get { return vdb; }
            set { vdb = value; }
        }

        private string descricaoDesc;
        public string DescricaoDesc
        {
            get { return descricaoDesc; }
            set { descricaoDesc = value; }
        }

        private float valorDesc;
        public float ValorDesc
        {
            get { return valorDesc; }
            set { valorDesc = value; }
        }
    }
}
