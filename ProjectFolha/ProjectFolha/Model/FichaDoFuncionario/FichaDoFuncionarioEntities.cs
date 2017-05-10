using ProjectFolha.Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.FichaDoFuncionario
{
    public class FichaDoFuncionarioEntities: ObservableBaseObject
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

        private DateTime nascimento;
        public DateTime Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; OnPropertyChange(); }
        }

        private string localNascimento;
        public string LocalNascimento
        {
            get { return localNascimento; }
            set { localNascimento = value; OnPropertyChange(); }
        }

        private string ufNascimento;
        public string UfNascimento
        {
            get { return ufNascimento; }
            set { ufNascimento = value; OnPropertyChange(); }
        }

        private string localNascimentoDesc;
        public string LocalNascimentoDesc
        {
            get { return localNascimentoDesc; }
            set { localNascimentoDesc = value; OnPropertyChange(); }
        }

        private string sexo;
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; OnPropertyChange(); }
        }

        private string estadoCivil;
        public string EstadoCiivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; OnPropertyChange(); }
        }

        private string nacionalidade;
        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; OnPropertyChange(); }
        }

        private string pai;
        public string Pai
        {
            get { return pai; }
            set { pai = value; OnPropertyChange(); }
        }

        private string mae;
        public string Mae
        {
            get { return mae; }
            set { mae = value; OnPropertyChange(); }
        }

        private string instrucao;
        public string Instrucao
        {
            get { return instrucao; }
            set { instrucao = value; OnPropertyChange(); }
        }

        private string rua;
        public string Rua
        {
            get { return rua; }
            set { rua = value; OnPropertyChange(); }
        }

        private string cep;
        public string Cep
        {
            get { return cep; }
            set { cep = value; OnPropertyChange(); }
        }

        private string bairro;
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; OnPropertyChange(); }
        }

        private string cidade;
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; OnPropertyChange(); }
        }

        private string uf;
        public string Uf
        {
            get { return uf; }
            set { uf = value; OnPropertyChange(); }
        }

        private string enderecoDesc;
        public string EnderecoDesc
        {
            get { return enderecoDesc; }
            set { enderecoDesc = value; OnPropertyChange(); }
        }

        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; OnPropertyChange(); }
        }

        private string celular;
        public string Celular
        {
            get { return celular; }
            set { celular = value; OnPropertyChange(); }
        }

        private string cpf;
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; OnPropertyChange(); }
        }

        private string identidade;
        public string Identidade
        {
            get { return identidade; }
            set { identidade = value; OnPropertyChange(); }
        }

        private DateTime dataIdentidade;
        public DateTime DataIdentidade
        {
            get { return dataIdentidade; }
            set { dataIdentidade = value; OnPropertyChange(); }
        }

        private string orgaoEmissor;
        public string OrgaoEmissor
        {
            get { return orgaoEmissor; }
            set { orgaoEmissor = value; OnPropertyChange(); }
        }

        private string ufIdentidade;
        public string UfIdentidade
        {
            get { return ufIdentidade; }
            set { ufIdentidade = value; OnPropertyChange(); }
        }

        private string nroCartTrab;
        public string NroCartTrab
        {
            get { return nroCartTrab; }
            set { nroCartTrab = value; OnPropertyChange(); }
        }

        private string serieCartTrab;
        public string SerieCartTrab
        {
            get { return serieCartTrab; }
            set { serieCartTrab = value; OnPropertyChange(); }
        }

        private DateTime dataCartTrab;
        public DateTime DataCartTrab
        {
            get { return dataCartTrab; }
            set { dataCartTrab = value; OnPropertyChange(); }
        }

        private string ufCartTrab;
        public string UfCartTrab
        {
            get { return ufCartTrab; }
            set { ufCartTrab = value; OnPropertyChange(); }
        }

        private string tituloEleitoral;
        public string TituloEleitoral
        {
            get { return tituloEleitoral; }
            set { tituloEleitoral = value; OnPropertyChange(); }
        }

        private string zonaEleitoral;
        public string ZonaEleitoral
        {
            get { return zonaEleitoral; }
            set { zonaEleitoral = value; OnPropertyChange(); }
        }

        private string secaoEleitoral;
        public string SecaoEleitoral
        {
            get { return secaoEleitoral; }
            set { secaoEleitoral = value; OnPropertyChange(); }
        }

        private string unidadeDesc;
        public string UnidadeDesc
        {
            get { return unidadeDesc; }
            set { unidadeDesc = value; OnPropertyChange(); }
        }

        private ObservableCollection<FichaDoFuncionarioContratoEntities> dadosDoContrato = new ObservableCollection<FichaDoFuncionarioContratoEntities>();
        public ObservableCollection<FichaDoFuncionarioContratoEntities> DadosDoContrato
        {
            get { return dadosDoContrato; }
            set { dadosDoContrato = value; OnPropertyChange(); }
        }
    }
}
