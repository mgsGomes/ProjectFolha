using ProjectFolha.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.ComprovanteDeRendimentos
{
    public class RendimentosTributaveis: ObservableBaseObject
    {
        private string mes;
        public string Mes
        {
            get { return mes; }
            set { mes = value; OnPropertyChange(); }
        }

        private decimal rendimentos;
        public decimal Rendimentos
        {
            get { return rendimentos; }
            set { rendimentos = value; OnPropertyChange(); }
        }

        private decimal contribuicaoPrevid;
        public decimal ContribuicaoPrevid
        {
            get { return contribuicaoPrevid; }
            set { contribuicaoPrevid = value; OnPropertyChange(); }
        }

        private decimal irrf;
        public decimal Irrf
        {
            get { return irrf; }
            set { irrf = value; OnPropertyChange(); }
        }
    }
}
