using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppEditableDeletableCollection;

namespace WpfAppEditableDeletableCollection
{
    public class MainWindowViewModel:BaseViewModel
    {
        public GenericDisplay Departments { get; set; }
        public MainWindowViewModel()
        {
            Departments = new SearchableDepartment(new List<object>() {
            new Department(){ DepartmentId=1,DepartmentName="Human Resource"},
            new Department(){ DepartmentId=2,DepartmentName="Software"},
            new Department(){ DepartmentId=3,DepartmentName="Hardware"}
            });
            
        }

    }
}
