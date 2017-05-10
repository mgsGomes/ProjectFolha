using ProjectFolha.Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFolha.Model.ComprovanteDeRendimentos
{
    public class ComprovanteDeRendimentosList: ObservableBaseObject
    {
        private ObservableCollection<ComprovanteDeRendimentosEntities> comprovanteDeRendimentos = new ObservableCollection<ComprovanteDeRendimentosEntities>();
        public ObservableCollection<ComprovanteDeRendimentosEntities> ComprovanteDeRendimentos
        {
            get { return comprovanteDeRendimentos; }
            set { comprovanteDeRendimentos = value; }
        }

        private ObservableCollection<ComprovanteDeRendimentosListaDeContratos> comprovanteDeRendimentosListaDeContratos = new ObservableCollection<ComprovanteDeRendimentosListaDeContratos>();
        public  ObservableCollection<ComprovanteDeRendimentosListaDeContratos> ComprovanteDeRendimentosListaDeContratos
        {
            get { return comprovanteDeRendimentosListaDeContratos; }
            set { comprovanteDeRendimentosListaDeContratos = value; }
        }

    }
}
