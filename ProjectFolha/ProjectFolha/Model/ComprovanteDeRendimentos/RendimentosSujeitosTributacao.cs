using ProjectFolha.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.ComprovanteDeRendimentos
{
    public class RendimentosSujeitosTributacao: ObservableBaseObject
    {
        private string mes;
        public string Mes
        {
            get { return mes; }
            set { mes = value; OnPropertyChange(); }
        }

        private decimal salario13;
        public decimal Salario13
        {
            get { return salario13; }
            set { salario13 = value; OnPropertyChange(); }
        }

        private decimal lucroDistribuido;
        public decimal LucroDistribuido
        {
            get { return lucroDistribuido; }
            set { lucroDistribuido = value; OnPropertyChange(); }
        }
    }
}
