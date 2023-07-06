using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace WpfAppEditableDeletableCollection
{
    internal class SearchableDepartment : GenericDisplay
    {
    
        public SearchableDepartment(List<object> items) : base(items)
        {
           
        }
        protected override string DisplayThing(object item)
        {
            Department D = item as Department;
            return D.DepartmentName.ToString();
        }


        protected override int IdThing(object item)
        {
            Department D = (Department)item;

            return D.DepartmentId;
        }
        protected override object ChangeObject(object item)
        {
            Department D = (Department)item;


            return D;
        }
        protected override object ChangeObjectToList(object item)
        {
            Department D = (Department)item;
            //List<Department> list = new List<Department>();
            //list.Add(D);
            DepartmentDTO d1 = new DepartmentDTO();
            d1.DepartmentId = D.DepartmentId;
            d1.DepartmentName = D.DepartmentName;
            d1.UpdateDept = new RelayCommand(UpdateClick);
            return d1;
        }
        protected override void UpdateDeptClick(object item)
        {
            


        }
    }
}