using ProjectFolha.Model.FichaDoFuncionario;
using ProjectFolha.ViewModel.FichaDoFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ProjectFolha.View.FichaDoFuncionario
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FichaDoFuncionarioDetail : TabbedPage
    {
        public FichaDoFuncionarioDetail(FichaDoFuncionarioDirectoryVM fichaDoFuncionario)
        {
            InitializeComponent();
            this.BindingContext = fichaDoFuncionario;

            lbl_Nome.Text = fichaDoFuncionario.FichasDoFuncionario[0].Nome;

            //Dados Pessoais
            lbl_Nascimento.Text = String.Format("{0:dd/MM/yyyy}", fichaDoFuncionario.FichasDoFuncionario[0].Nascimento);
            lbl_LocalNascimento.Text = fichaDoFuncionario.FichasDoFuncionario[0].LocalNascimentoDesc;
            lbl_Sexo.Text = fichaDoFuncionario.FichasDoFuncionario[0].Sexo;
            lbl_EstadoCivil.Text = fichaDoFuncionario.FichasDoFuncionario[0].EstadoCiivil;
            lbl_Mae.Text = fichaDoFuncionario.FichasDoFuncionario[0].Mae;
            lbl_Pai.Text = fichaDoFuncionario.FichasDoFuncionario[0].Pai;

            lbl_Instrucao.Text = fichaDoFuncionario.FichasDoFuncionario[0].Instrucao;

            lbl_Endereco.Text = fichaDoFuncionario.FichasDoFuncionario[0].Rua;
            lbl_Bairro.Text = fichaDoFuncionario.FichasDoFuncionario[0].Bairro;
            lbl_Cep.Text = fichaDoFuncionario.FichasDoFuncionario[0].Cep;
            lbl_Cidade.Text = fichaDoFuncionario.FichasDoFuncionario[0].Cidade + "/" + fichaDoFuncionario.FichasDoFuncionario[0].Uf;

            lbl_Telefone.Text = fichaDoFuncionario.FichasDoFuncionario[0].Telefone;
            lbl_Celular.Text = fichaDoFuncionario.FichasDoFuncionario[0].Celular;

            //Documentação
            lbl_NomeDoc.Text = fichaDoFuncionario.FichasDoFuncionario[0].Nome;
            lbl_Cpf.Text = fichaDoFuncionario.FichasDoFuncionario[0].Cpf;
            lbl_CodigoIdentidade.Text = fichaDoFuncionario.FichasDoFuncionario[0].Identidade;
            lbl_DataIdentidade.Text = String.Format("{0:dd/MM/yyyy}", fichaDoFuncionario.FichasDoFuncionario[0].DataIdentidade);
            lbl_OrgaoIdentidade.Text = fichaDoFuncionario.FichasDoFuncionario[0].OrgaoEmissor;
            lbl_UfIdentidade.Text = fichaDoFuncionario.FichasDoFuncionario[0].UfIdentidade;

            lbl_CodigoCartTrab.Text = fichaDoFuncionario.FichasDoFuncionario[0].NroCartTrab;
            lbl_DataCartTrab.Text = String.Format("{0:dd/MM/yyyy}", fichaDoFuncionario.FichasDoFuncionario[0].DataCartTrab);
            lbl_SerieCartTrab.Text = fichaDoFuncionario.FichasDoFuncionario[0].SerieCartTrab;
            lbl_UfCartTrab.Text = fichaDoFuncionario.FichasDoFuncionario[0].UfCartTrab;

            lbl_CodigoTitEleitoral.Text = fichaDoFuncionario.FichasDoFuncionario[0].TituloEleitoral;
            lbl_ZonaTitEleitoral.Text = fichaDoFuncionario.FichasDoFuncionario[0].ZonaEleitoral;
            lbl_SecaoTitEleitoral.Text = fichaDoFuncionario.FichasDoFuncionario[0].SecaoEleitoral;

            //Contrato
            lbl_NomeContrato.Text = fichaDoFuncionario.FichasDoFuncionario[0].Nome;
            lbl_ContratoUnidade.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].UnidadeDesc;

            lbl_CodigoContrato.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].Contrato.ToString();
            lbl_DataAdmissao.Text = String.Format("{0:dd/MM/yyyy}", fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].DataAdmissao);
            lbl_TempoDeCasa.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].TempoDeCasa;
            lbl_Cracha.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].Cracha;
            lbl_Plano.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].Plano;
            lbl_Classe.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].Classe;
            lbl_Faixa.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].Faixa;
            lbl_TempoDeFaixa.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].TempoDeFaixa;
            lbl_SalarioContratual.Text = String.Format("R$ {0:0.0,0}", fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].SalarioContratual);
            lbl_HorasContratuais.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].HorasContratuais;

            lbl_Sindicato.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].Sindicato;

            lbl_DescricaoCargo.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].Cargo;
            lbl_CboCargo.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].CboCargo;
            lbl_TempoDeCargo.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].TempoDeCargo;

            lbl_DescricaoFuncao.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].Funcao;
            lbl_CboFuncao.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].Cbofuncao;
            lbl_TempoDeFuncao.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].TempoDefuncao;

            lbl_Setor.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].Setor;

            lbl_PostoDeTrabalho.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].PostoDeTrabalho;

            lbl_ClassGerencial.Text = fichaDoFuncionario.FichasDoFuncionario[0].DadosDoContrato[0].ClassGerencial;
        }
    }
}
