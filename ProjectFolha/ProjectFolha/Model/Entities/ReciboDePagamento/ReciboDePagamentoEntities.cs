using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.Entities.ReciboDePagamento
{
    public class ReciboDePagamentoEntities
    {
        private string empresa;
        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        private int pessoa;
        public int Pessoa
        {
            get { return pessoa; }
            set { pessoa = value; }
        }

        private string unidade;
        public string Unidade
        {
            get { return unidade; }
            set { unidade = value; }
        }

        private int contrato;
        public int Contrato
        {
            get { return contrato; }
            set { contrato = value; }
        }


        private DateTime dataFolha;
        public DateTime DataFolha
        {
            get { return dataFolha; }
            set { dataFolha = value; }
        }

        private string codigoFolha;
        public string CodigoFolha
        {
            get { return codigoFolha; }
            set { codigoFolha = value; }
        }

        private float salarioContratual;
        public float SalarioContratual
        {
            get { return salarioContratual; }
            set { salarioContratual = value; }
        }

        private float salarioLiquido;
        public float SalarioLiquido
        {
            get { return salarioLiquido; }
            set { salarioLiquido = value; }
        }

        private ObservableCollection<ReciboDePagamentoVenctoEntities> vencimentos = new ObservableCollection<ReciboDePagamentoVenctoEntities>();
        public ObservableCollection<ReciboDePagamentoVenctoEntities> Vencimentos
        {
            get { return vencimentos; }
            set { vencimentos = value; }
        }

        private float totalVencto;
        public float TotalVencto
        {
            get { return totalVencto; }
            set { totalVencto = value; }
        }

        private ObservableCollection<ReciboDePagamentoDescEntities> descontos = new ObservableCollection<ReciboDePagamentoDescEntities>();
        public ObservableCollection<ReciboDePagamentoDescEntities> Descontos
        {
            get { return descontos; }
            set { descontos = value; }
        }

        private float totalDesc;
        public float TotalDesc
        {
            get { return totalDesc; }
            set { totalDesc = value; }
        }

        private ObservableCollection<ReciboDePagamentoBaseEntities> bases = new ObservableCollection<ReciboDePagamentoBaseEntities>();
        public ObservableCollection<ReciboDePagamentoBaseEntities> Bases
        {
            get { return bases; }
            set { bases = value; }
        }

    }
}
