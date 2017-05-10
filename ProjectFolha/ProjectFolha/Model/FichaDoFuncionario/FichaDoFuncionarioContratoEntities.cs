using ProjectFolha.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.FichaDoFuncionario
{
    public class FichaDoFuncionarioContratoEntities: ObservableBaseObject
    {
        private string unidade;
        public string Unidade
        {
            get { return unidade; }
            set { unidade = value; OnPropertyChange(); }
        }

        private string unidadeDesc;
        public string UnidadeDesc
        {
            get { return unidadeDesc; }
            set { unidadeDesc = value; OnPropertyChange(); }
        }

        private int contrato;
        public  int Contrato
        {
            get { return contrato; }
            set { contrato = value; OnPropertyChange(); }
        }

        private DateTime dataAdmissao;
        public DateTime DataAdmissao
        {
            get { return dataAdmissao; }
            set { dataAdmissao = value; OnPropertyChange(); }
        }

        private string tempoDeCasa;
        public string TempoDeCasa
        {
            get { return tempoDeCasa; }
            set { tempoDeCasa = value; OnPropertyChange(); }
        }

        private string cracha;
        public string Cracha
        {
            get { return cracha; }
            set { cracha = value; OnPropertyChange(); }
        }

        private string plano;
        public string Plano
        {
            get { return plano; }
            set { plano = value; OnPropertyChange(); }
        }

        private string classe;
        public string Classe
        {
            get { return classe; }
            set { classe = value; OnPropertyChange(); }
        }

        private string faixa;
        public string Faixa
        {
            get { return faixa; }
            set { faixa = value; OnPropertyChange(); }
        }

        private string tempoDeFaixa;
        public string TempoDeFaixa
        {
            get { return tempoDeFaixa; }
            set { tempoDeFaixa = value; OnPropertyChange(); }
        }

        private decimal salarioContratual;
        public decimal SalarioContratual
        {
            get { return salarioContratual; }
            set { salarioContratual = value; OnPropertyChange(); }
        }

        private string horasContratuais;
        public string HorasContratuais
        {
            get { return horasContratuais; }
            set { horasContratuais = value; OnPropertyChange(); }
        }

        private string sindicato;
        public string Sindicato
        {
            get { return sindicato; }
            set { sindicato = value; OnPropertyChange(); }
        }

        private string cargo;
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; OnPropertyChange(); }
        }

        private string cboCargo;
        public string CboCargo
        {
            get { return cboCargo; }
            set { cboCargo = value; OnPropertyChange(); }
        }

        private string tempoDeCargo;
        public string TempoDeCargo
        {
            get { return tempoDeCargo; }
            set { tempoDeCargo = value; OnPropertyChange(); }
        }

        private string funcao;
        public string Funcao
        {
            get { return funcao; }
            set { funcao = value; OnPropertyChange(); }
        }

        private string cbofuncao;
        public string Cbofuncao
        {
            get { return cbofuncao; }
            set { cbofuncao = value; OnPropertyChange(); }
        }

        private string tempoDefuncao;
        public string TempoDefuncao
        {
            get { return tempoDefuncao; }
            set { tempoDefuncao = value; OnPropertyChange(); }
        }

        private string setor;
        public string Setor
        {
            get { return setor; }
            set { setor = value; OnPropertyChange(); }
        }

        private string postoDeTrabalho;
        public string PostoDeTrabalho
        {
            get { return postoDeTrabalho; }
            set { postoDeTrabalho = value; OnPropertyChange(); }
        }

        private string classGerencial;
        public string ClassGerencial
        {
            get { return classGerencial; }
            set { classGerencial = value; OnPropertyChange(); }
        }



    }
}
