using ProjectFolha.Model.Entities.ReciboDePagamento;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.Services.ReciboDePagamento
{
    public class ServicoReciboDePagamento
    {
        public static ReciboDePagamentoList CarregaRecibo()
        {


            ObservableCollection<ReciboDePagamentoEntities> reciboDePagamento = new ObservableCollection<ReciboDePagamentoEntities>();
            ReciboDePagamentoList reciboDePagamentoList = new ReciboDePagamentoList();

            decimal lTotal = 0;           

            string[] names = { "Micael Gomes de Souza", "Micael Gomes de Souza"};
            string[] lastNames = { "Hernández", "García", "Martínez", "López", "González" };

            string[] vdbs = { "00001", "00023" };
            string[] descVdb = { "Salário", "Adic. p/Tempo de Serviço"};
            
            string[] vdbsDesc = { "00219", "00222", "00381", "00391" };
            string[] descVdbDesc = { "Vale Alimentação ou Refeição", "Seguro de Vida em Grupo", "Inss Sobre a Folha", "I.R.F Sobre a Folha"};

            string[] unidades = { "0001", "0002" };
            int[] contratos = { 1022, 1023 };

            decimal[] vdbsValor = { 2803, 84 };
            decimal[] vdbsValorDesc = { 74, 11, 317, 49 };

            Random rdn = new Random(DateTime.Now.Millisecond);

            var dataDaFolha = new DateTime(2016, 1, 1);

            for (int i = 0; i < 2; i++)
            {                
                for (int k = 0; k < 4; k++)
                {
                    ReciboDePagamentoEntities recibo = new ReciboDePagamentoEntities();
                    recibo.Empresa = "Empresa de testes";
                    recibo.Unidade = unidades[i];
                    recibo.Pessoa = "11111";
                    recibo.Contrato = contratos[i];
                    recibo.DataFolha = dataDaFolha.AddMonths(k);
                    recibo.CodigoFolha = "44";
                    if (i == 0)
                    {
                        recibo.SalarioContratual = 2456;
                    }
                    else
                    {
                        recibo.SalarioContratual = 3200;
                    }

                    for (int j = 0; j < 2; j++)
                    {
                        ReciboDePagamentoVenctoEntities vencimentos = new ReciboDePagamentoVenctoEntities();
                        vencimentos.Vdb = vdbs[j];
                        vencimentos.DescricaoVencto = descVdb[j];
                        if(i==0)
                        {
                            vencimentos.ValorVencto = (vdbsValor[j]);
                        }
                        else
                        {
                            vencimentos.ValorVencto = (vdbsValor[j] * 2);
                        }
                        
                        lTotal = lTotal + vencimentos.ValorVencto;
                        recibo.Vencimentos.Add(vencimentos);
                    };
                    recibo.TotalVencto = lTotal;
                    lTotal = 0;

                    for (int j = 0; j < 4; j++)
                    {
                        ReciboDePagamentoDescEntities descontos = new ReciboDePagamentoDescEntities();
                        descontos.Vdb = vdbsDesc[j];
                        descontos.DescricaoDesc = descVdbDesc[j];
                        if (i == 0)
                        {
                            descontos.ValorDesc = (vdbsValorDesc[j]);
                        }
                        else
                        {
                            descontos.ValorDesc = (vdbsValorDesc[j] * 2);
                        }
                        lTotal = lTotal + descontos.ValorDesc;
                        recibo.Descontos.Add(descontos);
                    };
                    recibo.TotalDesc = lTotal;
                    lTotal = 0;

                    if (i == 0)
                    {
                        recibo.TotalBaseInss = 2887;
                        recibo.TotalBaseIrrf = 2887;
                        recibo.TotalBaseFgts = 230;
                    }
                    else
                    {
                        recibo.TotalBaseInss = 2987;
                        recibo.TotalBaseIrrf = 2987;
                        recibo.TotalBaseFgts = 325;
                    }                   

                    recibo.SalarioLiquido = (recibo.TotalVencto - recibo.TotalDesc);

                    //student.Name = names[rdn.Next(0, 8)];
                    //student.LastName = $"{lastNames[rdn.Next(0, 5)]} {lastNames[rdn.Next(0, 5)]}";
                    //string group = rdn.Next(456, 458).ToString();
                    //student.Group = group;
                    //student.StudentNumber = rdn.Next(12384748, 32384748).ToString();
                    //student.Average = rdn.Next(100, 1000) / 10;
                    reciboDePagamento.Add(recibo);
                }                

            }
            reciboDePagamentoList.ReciboDePagamentoEntities = reciboDePagamento;
            return reciboDePagamentoList;
        }

        public static ReciboDePagamentoList CarregaListaDeContratosPessoa()
        {
            ObservableCollection<ReciboDePagamentoListaDeContratos> listaDeContratos = new ObservableCollection<ReciboDePagamentoListaDeContratos>();
            ReciboDePagamentoList reciboDePagamentoListaDeContratos = new ReciboDePagamentoList();

            string[] unidades = { "0001", "0002" };
            int[] contratos = { 1022, 1023 };
            string[] names = { "Micael Gomes de Souza", "Micael Gomes de Souza" };

            Random rdn = new Random(DateTime.Now.Millisecond);
            listaDeContratos = new ObservableCollection<ReciboDePagamentoListaDeContratos>();

            for (int i = 0; i < 2; i++)
            {
                ReciboDePagamentoListaDeContratos listaRecibo = new ReciboDePagamentoListaDeContratos();
                listaRecibo.Unidade = unidades[i];
                listaRecibo.Contrato = contratos[i];
                listaRecibo.UnidadeContrato = listaRecibo.Unidade + "/" + listaRecibo.Contrato.ToString() +" - " + names[i];
                listaDeContratos.Add(listaRecibo);     
            }

            reciboDePagamentoListaDeContratos.ReciboDePagamentoListaDeContratos = listaDeContratos;

            return reciboDePagamentoListaDeContratos;
        }


        public static ReciboDePagamentoList CarregaReciboPorContrato(string unidade, int contrato)
        {
            ReciboDePagamentoList reciboDePagamentoList = new ReciboDePagamentoList();
            ReciboDePagamentoList reciboDePagamentoPorContrato = new ReciboDePagamentoList();

            reciboDePagamentoList = CarregaRecibo();

            for(int i = 0;  i < reciboDePagamentoList.ReciboDePagamentoEntities.Count; i++)
            {
                if ((reciboDePagamentoList.ReciboDePagamentoEntities[i].Unidade == unidade) &&  
                    (reciboDePagamentoList.ReciboDePagamentoEntities[i].Contrato == contrato))
                {
                    reciboDePagamentoPorContrato.ReciboDePagamentoEntities.Add(reciboDePagamentoList.ReciboDePagamentoEntities[i]);
                }     
            }
            return reciboDePagamentoPorContrato;            
        }
    }
}
