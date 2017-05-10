using ProjectFolha.ViewModel.ComprovanteDeRendimentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ProjectFolha.View.ComprovanteDeRendimentos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComprovanteDeRendimentosDetail : TabbedPage
    {
        public ComprovanteDeRendimentosDetail(ComprovanteDeRendimentosDirectoryVM comprovanteRendimento)
        {
            InitializeComponent();
            this.BindingContext = comprovanteRendimento;

            //Comprovante
            lbl_Cnpj.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Cnpj;
            lbl_NomeEmpresarial.Text = comprovanteRendimento.ComprovanteDeRendimento[0].NomeEmpresa;

            lbl_Cpf.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Cpf;
            lbl_Nome.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Nome;
            lbl_UnidadeContrato.Text = comprovanteRendimento.ComprovanteDeRendimento[0].UnidadeContrato;

            lbl_RendTrib1.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendTrib1);
            lbl_RendTrib2.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendTrib2);
            lbl_RendTrib3.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendTrib3);
            lbl_RendTrib4.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendTrib4);
            lbl_RendTrib5.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendTrib5);

            lbl_RendIsento1.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendIsento1);
            lbl_RendIsento2.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendIsento2);
            lbl_RendIsento3.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendIsento3);
            lbl_RendIsento4.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendIsento4);
            lbl_RendIsento5.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendIsento5);
            lbl_RendIsento6.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendIsento6);
            lbl_RendIsento7.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendIsento7);

            lbl_RendSujeitos1.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendSujeitos1);
            lbl_RendSujeitos2.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendSujeitos2);
            lbl_RendSujeitos3.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendSujeitos3);

            lbl_NumeroProcesso.Text = comprovanteRendimento.ComprovanteDeRendimento[0].RendRecebidosNumeroProcesso;
            lbl_QuantMeses.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendRecebidosQuantMeses);
            lbl_NatRendimento.Text = comprovanteRendimento.ComprovanteDeRendimento[0].RendRecebidosNaturezaRendimento;
            lbl_RendRecebidos1.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendRecebidos1);
            lbl_RendRecebidos2.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendRecebidos2);
            lbl_RendRecebidos3.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendRecebidos3);
            lbl_RendRecebidos4.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendRecebidos4);
            lbl_RendRecebidos5.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendRecebidos5);
            lbl_RendRecebidos6.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].RendRecebidos6);

            lbl_InfoComplementarDesc.Text = comprovanteRendimento.ComprovanteDeRendimento[0].InfoComplementarDesc;
            lbl_InfoComplementarValor.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].InfoComplementarValor);

            lbl_NomeResponsavel.Text = comprovanteRendimento.ComprovanteDeRendimento[0].NomeResponsavel;
            lbl_DataResponsavel.Text = String.Format("{0:dd/MM/yyyy}", comprovanteRendimento.ComprovanteDeRendimento[0].DataResponsavel);

            //Anexo
            lbl_NomeFonte.Text = comprovanteRendimento.ComprovanteDeRendimento[0].NomeEmpresa;
            lbl_CnpjFonte.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Cnpj;
            lbl_NomeBeneficiaria.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Nome;
            lbl_UnidadeContratoAnexo.Text = comprovanteRendimento.ComprovanteDeRendimento[0].UnidadeContrato;
            lbl_CpfAnexo.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Cpf;
            lbl_NatRendimentoAnexo.Text = comprovanteRendimento.ComprovanteDeRendimento[0].NaturezaRendimento;

            lbl_Mes1.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[0].Mes;
            lbl_Rendimento1.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[0].Rendimentos);
            lbl_ContribPrev1.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[0].ContribuicaoPrevid);
            lbl_Irrf1.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[0].Irrf);

            lbl_Mes2.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[1].Mes;
            lbl_Rendimento2.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[1].Rendimentos);
            lbl_ContribPrev2.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[1].ContribuicaoPrevid);
            lbl_Irrf2.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[1].Irrf);

            lbl_Mes3.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[2].Mes;
            lbl_Rendimento3.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[2].Rendimentos);
            lbl_ContribPrev3.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[2].ContribuicaoPrevid);
            lbl_Irrf3.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[2].Irrf);

            lbl_Mes4.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[3].Mes;
            lbl_Rendimento4.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[3].Rendimentos);
            lbl_ContribPrev4.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[3].ContribuicaoPrevid);
            lbl_Irrf4.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[3].Irrf);

            lbl_Mes5.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[4].Mes;
            lbl_Rendimento5.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[4].Rendimentos);
            lbl_ContribPrev5.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[4].ContribuicaoPrevid);
            lbl_Irrf5.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[4].Irrf);

            lbl_Mes6.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[5].Mes;
            lbl_Rendimento6.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[5].Rendimentos);
            lbl_ContribPrev6.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[5].ContribuicaoPrevid);
            lbl_Irrf6.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[5].Irrf);

            lbl_Mes7.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[6].Mes;
            lbl_Rendimento7.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[6].Rendimentos);
            lbl_ContribPrev7.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[6].ContribuicaoPrevid);
            lbl_Irrf7.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[6].Irrf);

            lbl_Mes8.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[7].Mes;
            lbl_Rendimento8.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[7].Rendimentos);
            lbl_ContribPrev8.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[7].ContribuicaoPrevid);
            lbl_Irrf8.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[7].Irrf);

            lbl_Mes9.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[8].Mes;
            lbl_Rendimento9.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[8].Rendimentos);
            lbl_ContribPrev9.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[8].ContribuicaoPrevid);
            lbl_Irrf9.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[8].Irrf);

            lbl_Mes10.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[9].Mes;
            lbl_Rendimento10.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[9].Rendimentos);
            lbl_ContribPrev10.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[9].ContribuicaoPrevid);
            lbl_Irrf10.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[9].Irrf);

            lbl_Mes11.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[10].Mes;
            lbl_Rendimento11.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[10].Rendimentos);
            lbl_ContribPrev11.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[10].ContribuicaoPrevid);
            lbl_Irrf11.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[10].Irrf);

            lbl_Mes12.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[11].Mes;
            lbl_Rendimento12.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[11].Rendimentos);
            lbl_ContribPrev12.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[11].ContribuicaoPrevid);
            lbl_Irrf12.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosTributaveis[11].Irrf);

            lbl_TotRendimentos.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].TotalRendimentos);
            lbl_TotContribuicao.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].TotalContribuicao);
            lbl_TotIrrf.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].TotalIrrf);

            //Rendimentos Sujeitos à Tributação Exclusiva
            lbl_MesSuj1.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[0].Mes;
            lbl_DecimoSalario1.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[0].Salario13);
            lbl_LucroDist1.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[0].LucroDistribuido);

            lbl_MesSuj2.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[1].Mes;
            lbl_DecimoSalario2.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[1].Salario13);
            lbl_LucroDist2.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[1].LucroDistribuido);

            lbl_MesSuj3.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[2].Mes;
            lbl_DecimoSalario3.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[2].Salario13);
            lbl_LucroDist3.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[2].LucroDistribuido);

            lbl_MesSuj4.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[3].Mes;
            lbl_DecimoSalario4.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[3].Salario13);
            lbl_LucroDist4.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[3].LucroDistribuido);

            lbl_MesSuj5.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[4].Mes;
            lbl_DecimoSalario5.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[4].Salario13);
            lbl_LucroDist5.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[4].LucroDistribuido);

            lbl_MesSuj6.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[5].Mes;
            lbl_DecimoSalario6.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[5].Salario13);
            lbl_LucroDist6.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[5].LucroDistribuido);

            lbl_MesSuj7.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[6].Mes;
            lbl_DecimoSalario7.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[6].Salario13);
            lbl_LucroDist7.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[6].LucroDistribuido);

            lbl_MesSuj8.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[7].Mes;
            lbl_DecimoSalario8.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[7].Salario13);
            lbl_LucroDist8.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[7].LucroDistribuido);

            lbl_MesSuj9.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[8].Mes;
            lbl_DecimoSalario9.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[8].Salario13);
            lbl_LucroDist9.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[8].LucroDistribuido);

            lbl_MesSuj10.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[9].Mes;
            lbl_DecimoSalario10.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[9].Salario13);
            lbl_LucroDist10.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[9].LucroDistribuido);

            lbl_MesSuj11.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[10].Mes;
            lbl_DecimoSalario11.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[10].Salario13);
            lbl_LucroDist11.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[10].LucroDistribuido);

            lbl_MesSuj12.Text = comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[11].Mes;
            lbl_DecimoSalario12.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[11].Salario13);
            lbl_LucroDist12.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].RendimentosSujeitosTributacao[11].LucroDistribuido);

            lbl_TotDecimo13.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].Total13Salario);
            lbl_TotLucroDistribuido.Text = String.Format("{0:0.0,0}", comprovanteRendimento.ComprovanteDeRendimento[0].Anexo[0].TotalLucroDistribuido);

            lbl_NomeResponsavelAnexo.Text = comprovanteRendimento.ComprovanteDeRendimento[0].NomeResponsavel;
            lbl_DataResponsavelAnexo.Text = String.Format("{0:dd/MM/yyyy}", comprovanteRendimento.ComprovanteDeRendimento[0].DataResponsavel);

        }
    }
}
