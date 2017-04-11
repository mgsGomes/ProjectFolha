using ProjectFolha.Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
