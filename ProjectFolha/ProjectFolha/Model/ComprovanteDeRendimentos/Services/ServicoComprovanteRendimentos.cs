using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.ComprovanteDeRendimentos.Services
{
    public class ServicoComprovanteRendimentos
    {
        public static ComprovanteDeRendimentosList CarregaComprovanteDeRendimentos()
        {
            ObservableCollection<ComprovanteDeRendimentosEntities> comprovanteDeRendimentos = new ObservableCollection<ComprovanteDeRendimentosEntities>();
            ComprovanteDeRendimentosList comprovanteDeRendimentosLista = new ComprovanteDeRendimentosList();

            decimal totRendimentos = 0;
            decimal totcontribPrevid = 0;
            decimal totIrrf = 0;
            decimal totDecimoSalario = 0;
            decimal totLucros = 0;

            string[] names = { "Micael Gomes de Souza", "Micael Gomes de Souza" };
            string[] unidades = { "0001", "0002" };
            string[] unidadesDesc = { "Unidade Modelo de Testes", "Unidade Do Segundo Contrato" };
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };           
            int[] contratos = { 1022, 1023 };
            decimal[] rendimentos1 = { 2289, 3817, 1144, 2289, 3122, 2406, 2406, 4011, 1203, 2406, 2406, 2406 };
            decimal[] rendimentos2 = { 4872, 4872, 4872, 4872, 4872, 4872, 4872, 4872, 4872, 4872, 4872, 4872 };
            decimal[] contribPrevid1 = { 206, 328, 171, 206, 428, 216, 216, 361, 164, 216, 216, 216 };
            decimal[] contribPrevid2 = { 345, 438, 230, 438, 428, 219, 438, 438, 364, 116, 438, 456 };
            decimal[] irrf1 = { 13, 13, 0, 13, 59, 21, 21, 21, 0, 21, 21, 21 };
            decimal[] irrf2 = { 15, 14, 2, 13, 79, 44, 25, 21, 0, 21, 21, 21 };
            decimal[] decimoSalario1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2168, 0 };
            decimal[] decimoSalario2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4600, 0 };
            decimal[] lucros1 = { 0, 0, 718, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            decimal[] lucros2 = { 0, 0, 967, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for (var i = 0; i < 2; i++)
            {
                ComprovanteDeRendimentosEntities dadosDoComprovante = new ComprovanteDeRendimentosEntities();

                dadosDoComprovante.Cnpj = "90719238/0001-64";
                dadosDoComprovante.NomeEmpresa = "Empresa de Testes";
                dadosDoComprovante.Cpf = "01688687780";
                dadosDoComprovante.Nome = names[i];
                dadosDoComprovante.Unidade = unidades[i];
                dadosDoComprovante.Contrato = contratos[i];
                dadosDoComprovante.UnidadeContrato = unidades[i] + "/" + contratos[i];
                dadosDoComprovante.NaturezaRendimento = "0561 - Rendimentos do Trabalho Assalariado";
                //Rendimentos Tributáveis, deduções e imposto sobre a Renda Retido na Fonte
                if (i == 0)
                {
                    dadosDoComprovante.RendTrib1 = 29910;
                    dadosDoComprovante.RendTrib2 = 2948;
                    dadosDoComprovante.RendTrib3 = 0;
                    dadosDoComprovante.RendTrib4 = 0;
                    dadosDoComprovante.RendTrib5 = 228;
                }
                else
                {
                    dadosDoComprovante.RendTrib1 = 58464;
                    dadosDoComprovante.RendTrib2 = 4348;
                    dadosDoComprovante.RendTrib3 = 0;
                    dadosDoComprovante.RendTrib4 = 0;
                    dadosDoComprovante.RendTrib5 = 276;
                }
                //Rendimentos isentos e não tributaveis
                dadosDoComprovante.RendIsento1 = 0;
                dadosDoComprovante.RendIsento2 = 0;
                dadosDoComprovante.RendIsento3 = 0;
                dadosDoComprovante.RendIsento4 = 0;
                dadosDoComprovante.RendIsento5 = 0;
                dadosDoComprovante.RendIsento6 = 0;
                dadosDoComprovante.RendIsento7 = 0;
                //Rendimentos Sujeitos a Tributação Exclusiva
                if (i == 0)
                {
                    dadosDoComprovante.RendSujeitos1 = 2168;
                    dadosDoComprovante.RendSujeitos2 = 21;
                    dadosDoComprovante.RendSujeitos3 = 718;
                }
                else
                {
                    dadosDoComprovante.RendSujeitos1 = 4600;
                    dadosDoComprovante.RendSujeitos2 = 21;
                    dadosDoComprovante.RendSujeitos3 = 967;
                }
                //Rendimentos recebidos
                dadosDoComprovante.RendRecebidosNumeroProcesso = " ";
                dadosDoComprovante.RendRecebidosNaturezaRendimento = " ";
                dadosDoComprovante.RendRecebidosQuantMeses = 0;
                dadosDoComprovante.RendRecebidos1 = 0;
                dadosDoComprovante.RendRecebidos2 = 0;
                dadosDoComprovante.RendRecebidos3 = 0;
                dadosDoComprovante.RendRecebidos4 = 0;
                dadosDoComprovante.RendRecebidos5 = 0;
                dadosDoComprovante.RendRecebidos6 = 0;
                //Informações complementares
                dadosDoComprovante.InfoComplementarDesc = "Despesas Médico-Odonto-Hospitalares";
                dadosDoComprovante.InfoComplementarValor = 0;
                //Responsavel pelas informações
                dadosDoComprovante.NomeResponsavel = "Dono da Empresa";
                dadosDoComprovante.DataResponsavel = new DateTime(2017, 4, 21);

                //Carrega anexo
                ComprovanteDeRendimentosAnexoEntities anexo = new ComprovanteDeRendimentosAnexoEntities();
                
                totRendimentos = 0;
                totcontribPrevid = 0;
                totIrrf = 0;
                totDecimoSalario = 0;
                totLucros = 0;

                for (var j = 0; j < 12; j++)
                {
                    RendimentosTributaveis rendimentosTributaveis = new RendimentosTributaveis();
                    RendimentosSujeitosTributacao rendimentosSujeitos = new RendimentosSujeitosTributacao();

                    rendimentosTributaveis.Mes = meses[j];

                    if (i == 0)
                    {
                        rendimentosTributaveis.Rendimentos = rendimentos1[j];
                        rendimentosTributaveis.ContribuicaoPrevid = contribPrevid1[j];
                        rendimentosTributaveis.Irrf = irrf1[j];

                        totRendimentos = totRendimentos + rendimentos1[j];
                        totcontribPrevid = totcontribPrevid + contribPrevid1[j];
                        totIrrf = totIrrf + irrf1[j];

                        rendimentosSujeitos.Mes = meses[j];
                        rendimentosSujeitos.Salario13 = decimoSalario1[j];
                        rendimentosSujeitos.LucroDistribuido = lucros1[j];

                        totDecimoSalario = totDecimoSalario + decimoSalario1[j];
                        totLucros = totLucros + lucros1[j];
                        
                    }      
                    else
                    {
                        rendimentosTributaveis.Rendimentos = rendimentos2[j];
                        rendimentosTributaveis.ContribuicaoPrevid = contribPrevid2[j];
                        rendimentosTributaveis.Irrf = irrf2[j];

                        totRendimentos = totRendimentos + rendimentos2[j];
                        totcontribPrevid = totcontribPrevid + contribPrevid2[j];
                        totIrrf = totIrrf + irrf2[j];

                        rendimentosSujeitos.Mes = meses[j];
                        rendimentosSujeitos.Salario13 = decimoSalario2[j];
                        rendimentosSujeitos.LucroDistribuido = lucros2[j];

                        totDecimoSalario = totDecimoSalario + decimoSalario2[j];
                        totLucros = totLucros + lucros2[j];                        
                    }
                   
                    anexo.RendimentosTributaveis.Add(rendimentosTributaveis);
                    anexo.RendimentosSujeitosTributacao.Add(rendimentosSujeitos);

                }                                
                anexo.TotalRendimentos = totRendimentos;
                anexo.TotalContribuicao = totcontribPrevid;
                anexo.TotalIrrf = totIrrf;
                anexo.Total13Salario = totDecimoSalario;
                anexo.TotalLucroDistribuido = totLucros;

                dadosDoComprovante.Anexo.Add(anexo);

                comprovanteDeRendimentos.Add(dadosDoComprovante);
            }

            comprovanteDeRendimentosLista.ComprovanteDeRendimentos = comprovanteDeRendimentos;
            return comprovanteDeRendimentosLista;
        }

        public static ComprovanteDeRendimentosList CarregaListaDeContratosPessoaComprovante()
        {
            ObservableCollection<ComprovanteDeRendimentosListaDeContratos> listaDeContratos = new ObservableCollection<ComprovanteDeRendimentosListaDeContratos>();
            ComprovanteDeRendimentosList comprovanteDeRendimentosLista = new ComprovanteDeRendimentosList();

            string[] unidades = { "0001", "0002" };
            int[] contratos = { 1022, 1023 };
            string[] names = { "Micael Gomes de Souza", "Micael Gomes de Souza" };

            for (var i = 0; i < 2; i++)
            {
                ComprovanteDeRendimentosListaDeContratos lista = new ComprovanteDeRendimentosListaDeContratos();
                lista.Unidade = unidades[i];
                lista.Contrato = contratos[i];
                lista.Nome = names[i];
                lista.UnidadeContrato = unidades[i] + "/" + contratos[i] + " - " + names[i];
                listaDeContratos.Add(lista);
            }

            comprovanteDeRendimentosLista.ComprovanteDeRendimentosListaDeContratos = listaDeContratos;

            return comprovanteDeRendimentosLista;
        }

        public static ComprovanteDeRendimentosList CarregaComprovantePorContrato(string unidade, int contrato)
        {
            ComprovanteDeRendimentosList comprovanteList = new ComprovanteDeRendimentosList();
            ComprovanteDeRendimentosList comprovantePorContrato = new ComprovanteDeRendimentosList();

            comprovanteList = CarregaComprovanteDeRendimentos();

            for (int i = 0; i < comprovanteList.ComprovanteDeRendimentos.Count; i++)
            {
                if ((comprovanteList.ComprovanteDeRendimentos[i].Unidade == unidade) &&
                    (comprovanteList.ComprovanteDeRendimentos[i].Contrato == contrato))
                {
                    comprovantePorContrato.ComprovanteDeRendimentos.Add(comprovanteList.ComprovanteDeRendimentos[i]);
                }
            }
            return comprovantePorContrato;
        }
    }
}
