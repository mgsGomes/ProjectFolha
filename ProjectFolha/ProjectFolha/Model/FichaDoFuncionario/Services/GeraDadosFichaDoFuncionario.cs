using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.FichaDoFuncionario.Services
{
    public class GeraDadosFichaDoFuncionario
    {
        public static FichaDoFuncionarioList CarregaFichaDoFuncionario()
        {
            ObservableCollection<FichaDoFuncionarioEntities> fichaDoFuncionario = new ObservableCollection<FichaDoFuncionarioEntities>();
            FichaDoFuncionarioList fichaDoFuncionarioList = new FichaDoFuncionarioList();

            string[] names = { "Micael Gomes de Souza", "Micael Gomes de Souza" };
            string[] unidades = { "0001", "0002" };
            int[] contratos = { 1022, 1023 };

            for (var i = 0; i < 2; i++)
            {
                FichaDoFuncionarioEntities dadosDoFuncionario = new FichaDoFuncionarioEntities();

                dadosDoFuncionario.Empresa = "Empresa de Testes";
                dadosDoFuncionario.Unidade = unidades[i];
                dadosDoFuncionario.UnidadeDesc = unidades[i] + " - " + "Unidade Modelo de Testes";
                dadosDoFuncionario.Contrato = contratos[i];
                dadosDoFuncionario.Pessoa = "11111";
                dadosDoFuncionario.Nome = names[i];
                dadosDoFuncionario.Nascimento = new DateTime(1989, 1, 16);
                dadosDoFuncionario.LocalNascimento = "Caxias do Sul";
                dadosDoFuncionario.UfNascimento = "RS";
                dadosDoFuncionario.Sexo = "Masculino";
                dadosDoFuncionario.EstadoCiivil = "Solteiro";
                dadosDoFuncionario.Nacionalidade = "Brasileiro";
                dadosDoFuncionario.Pai = "Breno Marques de Souza";
                dadosDoFuncionario.Mae = "Eriete Aparecida Gomes de Souza";
                dadosDoFuncionario.Instrucao = "Superior Incompleto";
                dadosDoFuncionario.Rua = "Rua Irmão José, 301";
                dadosDoFuncionario.Cep = "95052-000";
                dadosDoFuncionario.Bairro = "Sagrada Família";
                dadosDoFuncionario.Cidade = "Caxias do Sul";
                dadosDoFuncionario.Uf = "RS";
                dadosDoFuncionario.Telefone = "54-32292921";
                dadosDoFuncionario.Celular = "54-981114412";
                dadosDoFuncionario.Cpf = "01688687780";
                dadosDoFuncionario.Identidade = "3418659365482";
                dadosDoFuncionario.DataIdentidade = new DateTime(2005, 5, 9);
                dadosDoFuncionario.OrgaoEmissor = "SJTC";
                dadosDoFuncionario.UfIdentidade = "RS";
                dadosDoFuncionario.NroCartTrab = "9826547";
                dadosDoFuncionario.DataCartTrab = new DateTime(2006, 2, 21);
                dadosDoFuncionario.SerieCartTrab = "0010";
                dadosDoFuncionario.UfCartTrab = "RS";
                dadosDoFuncionario.TituloEleitoral = "1048782643737";
                dadosDoFuncionario.ZonaEleitoral = "169";
                dadosDoFuncionario.SecaoEleitoral = "0144";
                dadosDoFuncionario.EnderecoDesc = dadosDoFuncionario.Cidade + "/" + dadosDoFuncionario.Uf;
                dadosDoFuncionario.LocalNascimentoDesc = dadosDoFuncionario.LocalNascimento + "/" + dadosDoFuncionario.UfNascimento;

                fichaDoFuncionario.Add(dadosDoFuncionario);
            }

            fichaDoFuncionarioList.FichaDoFuncionarioEntities = fichaDoFuncionario;
            return fichaDoFuncionarioList;

        }

        public static FichaDoFuncionarioList CarregaListaDeContratosPessoa()
        {
            ObservableCollection<FichaDoFuncionarioListaDeContratos> listaDeContratos = new ObservableCollection<FichaDoFuncionarioListaDeContratos>();
            FichaDoFuncionarioList fichaDeFuncionarioListaDeContratos = new FichaDoFuncionarioList();

            string[] unidades = { "0001", "0002" };
            int[] contratos = { 1022, 1023 };
            string[] names = { "Micael Gomes de Souza", "Micael Gomes de Souza" };

            for (var i = 0; i < 2; i++)
            {
                FichaDoFuncionarioListaDeContratos lista = new FichaDoFuncionarioListaDeContratos();
                lista.Unidade = unidades[i];
                lista.Contrato = contratos[i];
                lista.Nome = names[i];
                lista.UnidadeContrato = unidades[i] + "/" + contratos[i] + " - " + names[i];
                listaDeContratos.Add(lista);
            }

            fichaDeFuncionarioListaDeContratos.FichaDoFuncionarioListaDeContratos = listaDeContratos;

            return fichaDeFuncionarioListaDeContratos;
        }

        public static FichaDoFuncionarioList CarregaFichaPorContrato(string unidade, int contrato)
        {
            FichaDoFuncionarioList fichaDoFuncionarioList = new FichaDoFuncionarioList();
            FichaDoFuncionarioList fichaDoFuncionarioPorContrato = new FichaDoFuncionarioList();

            fichaDoFuncionarioList = CarregaFichaDoFuncionario();

            for (int i = 0; i < fichaDoFuncionarioList.FichaDoFuncionarioEntities.Count; i++)
            {
                if ((fichaDoFuncionarioList.FichaDoFuncionarioEntities[i].Unidade == unidade) &&
                    (fichaDoFuncionarioList.FichaDoFuncionarioEntities[i].Contrato == contrato))
                {
                    fichaDoFuncionarioPorContrato.FichaDoFuncionarioEntities.Add(fichaDoFuncionarioList.FichaDoFuncionarioEntities[i]);
                }
            }
            return fichaDoFuncionarioPorContrato;
        }
    }
}
