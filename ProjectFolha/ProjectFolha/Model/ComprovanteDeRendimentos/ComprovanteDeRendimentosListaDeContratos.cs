using ProjectFolha.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.ComprovanteDeRendimentos
{
    public class ComprovanteDeRendimentosListaDeContratos: ObservableBaseObject
    {
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

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; OnPropertyChange(); }
        }

        private string unidadeContratoNome;
        public string UnidadeContrato
        {
            get { return unidadeContratoNome; }
            set { unidadeContratoNome = value; OnPropertyChange(); }
        }
    }
}
