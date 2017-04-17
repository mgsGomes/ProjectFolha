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
        }
    }
}
