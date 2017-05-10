using ProjectFolha.Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.ComprovanteDeRendimentos
{
    public class ComprovanteDeRendimentosEntities: ObservableBaseObject
    {
        private string cnpj;
        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; OnPropertyChange(); }
        }

        private string nomeEmpresa;
        public string NomeEmpresa
        {
            get { return nomeEmpresa; }
            set { nomeEmpresa = value; OnPropertyChange(); }
        }

        private string cpf;
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; OnPropertyChange(); }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; OnPropertyChange(); }
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

        private string unidadeContrato;
        public string UnidadeContrato
        {
            get { return unidadeContrato; }
            set { unidadeContrato = value; OnPropertyChange(); }
        }

        private string naturezaRendimento;
        public string NaturezaRendimento
        {
            get { return naturezaRendimento; }
            set { naturezaRendimento = value; OnPropertyChange(); }
        }

        //Rendimentos Tributáveis, deduções e imposto sobre a Renda Retido na Fonte
        private decimal rendTrib1;
        public decimal RendTrib1
        {
            get { return rendTrib1; }
            set { rendTrib1 = value; OnPropertyChange(); }
        }

        private decimal rendTrib2;
        public decimal RendTrib2
        {
            get { return rendTrib2; }
            set { rendTrib2 = value; OnPropertyChange(); }
        }

        private decimal rendTrib3;
        public decimal RendTrib3
        {
            get { return rendTrib3; }
            set { rendTrib3 = value; OnPropertyChange(); }
        }

        private decimal rendTrib4;
        public decimal RendTrib4
        {
            get { return rendTrib4; }
            set { rendTrib4 = value; OnPropertyChange(); }
        }

        private decimal rendTrib5;
        public decimal RendTrib5
        {
            get { return rendTrib5; }
            set { rendTrib5 = value; OnPropertyChange(); }
        }

        //Rendimentos isentos e não tributaveis
        private decimal rendIsento1;
        public decimal RendIsento1
        {
            get { return rendIsento1; }
            set { rendIsento1 = value; OnPropertyChange(); }
        }

        private decimal rendIsento2;
        public decimal RendIsento2
        {
            get { return rendIsento2; }
            set { rendIsento2 = value; OnPropertyChange(); }
        }

        private decimal rendIsento3;
        public decimal RendIsento3
        {
            get { return rendIsento3; }
            set { rendIsento3 = value; OnPropertyChange(); }
        }

        private decimal rendIsento4;
        public decimal RendIsento4
        {
            get { return rendIsento4; }
            set { rendIsento4 = value; OnPropertyChange(); }
        }

        private decimal rendIsento5;
        public decimal RendIsento5
        {
            get { return rendIsento5; }
            set { rendIsento5 = value; OnPropertyChange(); }
        }

        private decimal rendIsento6;
        public decimal RendIsento6
        {
            get { return rendIsento6; }
            set { rendIsento6 = value; OnPropertyChange(); }
        }

        private decimal rendIsento7;
        public decimal RendIsento7
        {
            get { return rendIsento7; }
            set { rendIsento7 = value; OnPropertyChange(); }
        }

        //Rendimentos Sujeitos a Tributação Exclusiva
        private decimal rendSujeitos1;
        public decimal RendSujeitos1
        {
            get { return rendSujeitos1; }
            set { rendSujeitos1 = value; OnPropertyChange(); }
        }

        private decimal rendSujeitos2;
        public decimal RendSujeitos2
        {
            get { return rendSujeitos2; }
            set { rendSujeitos2 = value; OnPropertyChange(); }
        }

        private decimal rendSujeitos3;
        public decimal RendSujeitos3
        {
            get { return rendSujeitos3; }
            set { rendSujeitos3 = value; OnPropertyChange(); }
        }

        //Rendimentos recebidos
        private string rendRecebidosNumeroProcesso;
        public string RendRecebidosNumeroProcesso
        {
            get { return rendRecebidosNumeroProcesso; }
            set { rendRecebidosNumeroProcesso = value; OnPropertyChange(); }
        }

        private decimal rendRecebidosQuantMeses;
        public decimal RendRecebidosQuantMeses
        {
            get { return rendRecebidosQuantMeses; }
            set { rendRecebidosQuantMeses = value; OnPropertyChange(); }
        }

        private string rendRecebidosNaturezaRendimento;
        public string RendRecebidosNaturezaRendimento
        {
            get { return rendRecebidosNaturezaRendimento; }
            set { rendRecebidosNaturezaRendimento = value; OnPropertyChange(); }
        }

        private decimal rendRecebidos1;
        public decimal RendRecebidos1
        {
            get { return rendRecebidos1; }
            set { rendRecebidos1 = value; OnPropertyChange(); }
        }

        private decimal rendRecebidos2;
        public decimal RendRecebidos2
        {
            get { return rendRecebidos2; }
            set { rendRecebidos2 = value; OnPropertyChange(); }
        }

        private decimal rendRecebidos3;
        public decimal RendRecebidos3
        {
            get { return rendRecebidos3; }
            set { rendRecebidos3 = value; OnPropertyChange(); }
        }

        private decimal rendRecebidos4;
        public decimal RendRecebidos4
        {
            get { return rendRecebidos4; }
            set { rendRecebidos4 = value; OnPropertyChange(); }
        }

        private decimal rendRecebidos5;
        public decimal RendRecebidos5
        {
            get { return rendRecebidos5; }
            set { rendRecebidos5 = value; OnPropertyChange(); }
        }

        private decimal rendRecebidos6;
        public decimal RendRecebidos6
        {
            get { return rendRecebidos6; }
            set { rendRecebidos6 = value; OnPropertyChange(); }
        }

        //Informações complementares
        private string infoComplementarDesc;
        public string InfoComplementarDesc
        {
            get { return infoComplementarDesc; }
            set { infoComplementarDesc = value; OnPropertyChange(); }
        }

        private decimal infoComplementarValor;
        public decimal InfoComplementarValor
        {
            get { return infoComplementarValor; }
            set { infoComplementarValor = value; OnPropertyChange(); }
        }

        //Responsavel pelas informações
        private string nomeResponsavel;
        public string NomeResponsavel
        {
            get { return nomeResponsavel; }
            set { nomeResponsavel = value; OnPropertyChange(); }
        }

        private DateTime dataResponsavel;
        public DateTime DataResponsavel
        {
            get { return dataResponsavel; }
            set { dataResponsavel = value; OnPropertyChange(); }
        }

        private ObservableCollection<ComprovanteDeRendimentosAnexoEntities> anexo = new ObservableCollection<ComprovanteDeRendimentosAnexoEntities>();
        public ObservableCollection<ComprovanteDeRendimentosAnexoEntities> Anexo
        {
            get { return anexo; }
            set { anexo = value; OnPropertyChange(); }
        }
    }
}
