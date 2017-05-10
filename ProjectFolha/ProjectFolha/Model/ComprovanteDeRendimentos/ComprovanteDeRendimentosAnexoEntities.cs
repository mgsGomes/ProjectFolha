using ProjectFolha.Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.ComprovanteDeRendimentos
{
    public class ComprovanteDeRendimentosAnexoEntities: ObservableBaseObject
    {
        private ObservableCollection<RendimentosTributaveis> rendimentosTributaveis = new ObservableCollection<RendimentosTributaveis>();
        public ObservableCollection<RendimentosTributaveis> RendimentosTributaveis
        {
            get { return rendimentosTributaveis; }
            set { rendimentosTributaveis = value; OnPropertyChange(); }
        }

        private ObservableCollection<RendimentosSujeitosTributacao> rendimentosSujeitosTributacao = new ObservableCollection<RendimentosSujeitosTributacao>();
        public ObservableCollection<RendimentosSujeitosTributacao> RendimentosSujeitosTributacao
        {
            get { return rendimentosSujeitosTributacao; }
            set { rendimentosSujeitosTributacao = value; OnPropertyChange(); }
        }

        private decimal totalRendimentos;
        public decimal TotalRendimentos
        {
            get { return totalRendimentos; }
            set { totalRendimentos = value; OnPropertyChange(); }
        }

        private decimal totalContribuicao;
        public decimal TotalContribuicao
        {
            get { return totalContribuicao; }
            set { totalContribuicao = value; OnPropertyChange(); }
        }

        private decimal totalIrrf;
        public decimal TotalIrrf
        {
            get { return totalIrrf; }
            set { totalIrrf = value; OnPropertyChange(); }
        }

        private decimal total13Salario;
        public decimal Total13Salario
        {
            get { return total13Salario; }
            set { total13Salario = value; OnPropertyChange(); }
        }

        private decimal totalLucroDistribuido;
        public decimal TotalLucroDistribuido
        {
            get { return totalLucroDistribuido; }
            set { totalLucroDistribuido = value; OnPropertyChange(); }
        }
    }
}
