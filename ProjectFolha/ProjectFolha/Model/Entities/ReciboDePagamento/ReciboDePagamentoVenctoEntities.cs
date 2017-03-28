using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.Entities.ReciboDePagamento
{
    public class ReciboDePagamentoVenctoEntities
    {
        private string vdb;
        public string Vdb
        {
            get { return vdb; }
            set { vdb = value; }
        }

        private string descricaoVencto;
        public string DescricaoVencto
        {
            get { return descricaoVencto; }
            set { descricaoVencto = value; }
        }

        private float valorVencto;
        public float ValorVencto
        {
            get { return valorVencto; }
            set { valorVencto = value; }
        }
    }
}
