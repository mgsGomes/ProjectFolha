using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.Entities.ReciboDePagamento
{
    public class ReciboDePagamentoBaseEntities
    {
        private string vdb;
        public string Vdb
        {
            get { return vdb; }
            set { vdb = value; }
        }

        private string descricaoBase;
        public string DescricaoBase
        {
            get { return descricaoBase; }
            set { descricaoBase = value; }
        }

        private float valorBase;
        public float ValorBase
        {
            get { return valorBase; }
            set { valorBase = value; }
        }
    }
}
