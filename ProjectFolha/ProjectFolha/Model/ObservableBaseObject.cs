using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProjectFolha.Model.Entities
{
    public class ObservableBaseObject : INotifyPropertyChanged
    {
        public ObservableBaseObject()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged = delegate
        {

        };

        public void OnPropertyChange([CallerMemberName] string Name = "")
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(Name));
        }
    }
}
