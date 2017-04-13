using ProjectFolha.Model.Entities;
using ProjectFolha.Model.FichaDoFuncionario;
using ProjectFolha.Model.FichaDoFuncionario.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectFolha.ViewModel.FichaDoFuncionario
{
    public class FichaDoFuncionarioDirectoryVM: ObservableBaseObject
    {
       
        public ObservableCollection<FichaDoFuncionarioEntities> FichasDoFuncionario { get; set; }
        public ObservableCollection<FichaDoFuncionarioListaDeContratos> FichaListaDeContratos { get; set; }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChange(); }
        }

        public Command CarregaFichaDoFuncionario
        {
            get;
            set;
        }

        public FichaDoFuncionarioDirectoryVM()
        {
            FichasDoFuncionario = new ObservableCollection<FichaDoFuncionarioEntities>();
            FichaListaDeContratos = new ObservableCollection<FichaDoFuncionarioListaDeContratos>();

            IsBusy = false;
            CarregaFichaDoFuncionario = new Command((obj) => CarregaFicha());
        }

        async void CarregaFicha()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var FichaCarregada = GeraDadosFichaDoFuncionario.CarregaFichaDoFuncionario();

                foreach (var ficha in FichaCarregada.FichaDoFuncionarioEntities)
                {
                    FichasDoFuncionario.Add(ficha);
                }


            }

            IsBusy = false;

        }

        public async void CarregaFichaLista()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var FichaCarregada = GeraDadosFichaDoFuncionario.CarregaListaDeContratosPessoa();

                foreach (var ficha in FichaCarregada.FichaDoFuncionarioListaDeContratos)
                {
                    FichaListaDeContratos.Add(ficha);
                }
            }

            IsBusy = false;
        }
    }
}
