using ProjectFolha.Model.Entities.ReciboDePagamento;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.Services.ReciboDePagamento
{
    public class GeraDadosAleatorioTeste
    {
        public static ReciboDePagamentoList CarregaReciboTeste()
        {


            ObservableCollection<ReciboDePagamentoEntities> reciboDePagamento = new ObservableCollection<ReciboDePagamentoEntities>();
            ReciboDePagamentoList reciboDePagamentoList = new ReciboDePagamentoList();

            decimal lTotal = 0;


            reciboDePagamento = new ObservableCollection<ReciboDePagamentoEntities>();

            string[] names = { "José Luis", "Miguel Ángel", "José Francisco", "Jesús Antonio",
                                "Sofía", "Camila", "Valentina", "Isabella", "Ximena"};
            string[] lastNames = { "Hernández", "García", "Martínez", "López", "González" };

            string[] vdbs = { "00010", "00020", "00030", "00040", "00050", "00060", "00070", "00080" };

            string[] vdbsDesc = { "Vdb 1", "Vdb 2" , "Vdb 3" , "Vdb 4" , "Vdb 5" , "Vdb 6" , "Vdb 7" , "Vdb 8" };

            decimal[] vdbsValor = { 1100, 1200, 1300, 1400, 1500, 1600, 1700, 1800 };
            decimal[] vdbsValorDesc = { 11, 12, 13, 14, 15, 16, 17, 18 };

            Random rdn = new Random(DateTime.Now.Millisecond);

            reciboDePagamento = new ObservableCollection<ReciboDePagamentoEntities>();

            for (int i = 0; i < 20; i++)
            {
                ReciboDePagamentoEntities recibo = new ReciboDePagamentoEntities();
                //recibo.Empresa = "Empresa teste";
                recibo.Empresa = names[rdn.Next(0, 8)];
                recibo.Unidade = "0001";
                recibo.Pessoa = "11111";
                recibo.Contrato = 1;
                recibo.DataFolha = new DateTime(2017, 1, i+1);
                recibo.CodigoFolha = "44";
                recibo.SalarioContratual = 2456;                

                for (int j = 0; j < 20; j++)
                {
                    ReciboDePagamentoVenctoEntities vencimentos = new ReciboDePagamentoVenctoEntities();
                    vencimentos.Vdb = vdbs[rdn.Next(0, 7)];
                    vencimentos.DescricaoVencto = vdbsDesc[rdn.Next(0, 7)];
                    vencimentos.ValorVencto = vdbsValor[rdn.Next(0, 7)];
                    lTotal = lTotal + vencimentos.ValorVencto;
                    recibo.Vencimentos.Add(vencimentos);
                };
                recibo.TotalVencto = lTotal;
                lTotal = 0;

                for (int j = 0; j < 7; j++)
                {
                    ReciboDePagamentoDescEntities descontos = new ReciboDePagamentoDescEntities();
                    descontos.Vdb = vdbs[rdn.Next(0, 7)];
                    descontos.DescricaoDesc = vdbsDesc[rdn.Next(0, 7)];
                    descontos.ValorDesc = vdbsValorDesc[rdn.Next(0, 7)];
                    lTotal = lTotal + descontos.ValorDesc;
                    recibo.Descontos.Add(descontos);
                };
                recibo.TotalDesc = lTotal;
                lTotal = 0;

                for (int j = 0; j < 7; j++)
                {
                    ReciboDePagamentoBaseEntities bases = new ReciboDePagamentoBaseEntities();
                    bases.Vdb = vdbs[rdn.Next(0, 7)];
                    bases.DescricaoBase = vdbsDesc[rdn.Next(0, 7)];
                    bases.ValorBase = vdbsValor[rdn.Next(0, 7)];                    
                    recibo.Bases.Add(bases);
                };

                recibo.SalarioLiquido = (recibo.TotalVencto - recibo.TotalDesc);             

                //student.Name = names[rdn.Next(0, 8)];
                //student.LastName = $"{lastNames[rdn.Next(0, 5)]} {lastNames[rdn.Next(0, 5)]}";
                //string group = rdn.Next(456, 458).ToString();
                //student.Group = group;
                //student.StudentNumber = rdn.Next(12384748, 32384748).ToString();
                //student.Average = rdn.Next(100, 1000) / 10;

                reciboDePagamento.Add(recibo);

            }
            reciboDePagamentoList.ReciboDePagamentoEntities = reciboDePagamento;
            return reciboDePagamentoList;
        }

        public static ReciboDePagamentoList CarregaListaDeContratosPessoa()
        {
            ObservableCollection<ReciboDePagamentoListaDeContratos> listaDeContratos = new ObservableCollection<ReciboDePagamentoListaDeContratos>();
            ReciboDePagamentoList reciboDePagamentoListaDeContratos = new ReciboDePagamentoList();

            string[] unidades = { "00010", "00020", "00030", "00040", "00050", "00060", "00070", "00080" };
            int[] contratos = { 10010, 10020, 10030, 10040, 10050, 10060, 10070, 10080 };

            Random rdn = new Random(DateTime.Now.Millisecond);
            listaDeContratos = new ObservableCollection<ReciboDePagamentoListaDeContratos>();

            for (int i = 0; i < 4; i++)
            {
                ReciboDePagamentoListaDeContratos listaRecibo = new ReciboDePagamentoListaDeContratos();
                listaRecibo.Unidade = unidades[rdn.Next(0, 7)];
                listaRecibo.Contrato = contratos[rdn.Next(0, 7)];
                listaRecibo.UnidadeContrato = listaRecibo.Unidade + "/" + listaRecibo.Contrato.ToString();
                listaDeContratos.Add(listaRecibo);     
            }

            reciboDePagamentoListaDeContratos.ReciboDePagamentoListaDeContratos = listaDeContratos;

            return reciboDePagamentoListaDeContratos;
        }
    }
}
