using ProjectFolha.Model.Entities;
using System.Collections.ObjectModel;

namespace ProjectFolha.Model.FichaDoFuncionario
{
    public class FichaDoFuncionarioList: ObservableBaseObject
    {
        private ObservableCollection<FichaDoFuncionarioEntities> fichaDoFuncionarioEntities = new ObservableCollection<FichaDoFuncionarioEntities>();
        public ObservableCollection<FichaDoFuncionarioEntities> FichaDoFuncionarioEntities
        {
            get { return fichaDoFuncionarioEntities; }
            set { fichaDoFuncionarioEntities = value; }
        }

        private ObservableCollection<FichaDoFuncionarioListaDeContratos> fichaDoFuncionarioListaDeContratos = new ObservableCollection<FichaDoFuncionarioListaDeContratos>();
        public ObservableCollection<FichaDoFuncionarioListaDeContratos> FichaDoFuncionarioListaDeContratos
        {
            get { return fichaDoFuncionarioListaDeContratos; }
            set { fichaDoFuncionarioListaDeContratos = value; }
        }


    }
}
