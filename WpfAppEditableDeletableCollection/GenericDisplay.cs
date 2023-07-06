using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Navigation;

namespace WpfAppEditableDeletableCollection
{
    public class GenericDisplay : BaseViewModel
    {
        public ObservableCollection<object> MainList { get; set; }
        public ObservableCollection<DepartmentDTO> ListDetail { get; set; }
        public ObservableCollection<Naming> ListUC { get; set; }
        public GenericDisplay(List<object> items)
        {

            MainList = new ObservableCollection<object>(items);
            Change();
        }

        private void Change()
        {
            ListUC = new ObservableCollection<Naming>();
            foreach (var item in MainList)
            {

                ListUC.Add(new Naming() { 
                    id = IdThing(item), 
                    Name1 = DisplayThing(item), 
                    OnRemoveClick = new RelayCommand(DeleteItem),
                    OnUpdateClick = new RelayCommand(UpdateItem),
                });

            }
            OnPropertyChanged(nameof(ListUC));
        }

        public void UpdateItem(object obj)
        {
            var newobj = (Naming)obj;
            ListDetail = new ObservableCollection<DepartmentDTO>();
            foreach (var item in MainList)
            {
                int i = IdThing(item);
                if (i == newobj.id)
                {
                   // ListDetail = new ObservableCollection<object>(ChangeObject(item));
                    ListDetail.Add((DepartmentDTO)ChangeObjectToList(item));
                    OnPropertyChanged(nameof(ListDetail));
                    break;
                }
            }
        }
        protected void UpdateClick(object obj)
        {
            var newobj = (DepartmentDTO)obj;
            foreach (var item in MainList)
            {
                int i = IdThing(item);
                if (i == newobj.DepartmentId)
                {
                    MainList.Remove(ChangeObject(item));
                    MainList.Add(new Department() { DepartmentId=newobj.DepartmentId,DepartmentName=newobj.DepartmentName});
                    
                    OnPropertyChanged(nameof(ListDetail));
                    Change();
                    break;
                }
            }

        }
        protected void DeleteItem(object obj)
        {
            var newobj = (Naming)obj;

            foreach (var item in MainList)
            {
                int i = IdThing(item);
                if (i == newobj.id)
                {
                    MainList.Remove(ChangeObject(item));
                    OnPropertyChanged(nameof(MainList));
                    Change();
                    break;
                }
            }
        }

        protected virtual object ChangeObject(object item)
        {
            return item.ToString();
        }

        protected virtual string DisplayThing(object item)
        {
            throw new NotImplementedException();
        }

        protected virtual int IdThing(object item)
        {
            throw new NotImplementedException();
        }
        protected virtual object ChangeObjectToList(object item)
        {
            throw new NotImplementedException();
        }
        protected virtual void UpdateDeptClick(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
