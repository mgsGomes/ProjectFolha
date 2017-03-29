using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.Entities.ReciboDePagamento
{
    public class ReciboDePagamentoEntities: ObservableBaseObject
    {
        private string empresa;
        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; OnPropertyChange(); }
        }

        private string pessoa;
        public string Pessoa
        {
            get { return pessoa; }
            set { pessoa = value; OnPropertyChange(); }
        }

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


        private DateTime dataFolha;
        public DateTime DataFolha
        {
            get { return dataFolha; }
            set { dataFolha = value; OnPropertyChange(); }
        }

        private string codigoFolha;
        public string CodigoFolha
        {
            get { return codigoFolha; }
            set { codigoFolha = value; OnPropertyChange(); }
        }

        private decimal salarioContratual;
        public decimal SalarioContratual
        {
            get { return salarioContratual; }
            set { salarioContratual = value; OnPropertyChange(); }
        }

        private decimal salarioLiquido;
        public decimal SalarioLiquido
        {
            get { return salarioLiquido; }
            set { salarioLiquido = value; OnPropertyChange(); }
        }

        private ObservableCollection<ReciboDePagamentoVenctoEntities> vencimentos = new ObservableCollection<ReciboDePagamentoVenctoEntities>();
        public ObservableCollection<ReciboDePagamentoVenctoEntities> Vencimentos
        {
            get { return vencimentos; }
            set { vencimentos = value; OnPropertyChange(); }
        }

        private decimal totalVencto;
        public decimal TotalVencto
        {
            get { return totalVencto; }
            set { totalVencto = value; OnPropertyChange(); }
        }

        private ObservableCollection<ReciboDePagamentoDescEntities> descontos = new ObservableCollection<ReciboDePagamentoDescEntities>();
        public ObservableCollection<ReciboDePagamentoDescEntities> Descontos
        {
            get { return descontos; }
            set { descontos = value; OnPropertyChange(); }
        }

        private decimal totalDesc;
        public decimal TotalDesc
        {
            get { return totalDesc; }
            set { totalDesc = value; OnPropertyChange(); }
        }

        private ObservableCollection<ReciboDePagamentoBaseEntities> bases = new ObservableCollection<ReciboDePagamentoBaseEntities>();
        public ObservableCollection<ReciboDePagamentoBaseEntities> Bases
        {
            get { return bases; }
            set { bases = value; OnPropertyChange(); }
        }

    }
}
