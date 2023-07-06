using System.ComponentModel;
using System;
using System.Collections;
using System.Windows.Input;

namespace WpfAppEditableDeletableCollection
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public Object ListUC1 { get; set; } = new Object();
        public event PropertyChangedEventHandler PropertyChanged;
        public IList collectionList { get; set; }

        public RelayCommand OnRemoveClick { get; set; }
        public RelayCommand OnUpdateClick { get; set; }

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}