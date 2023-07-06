using System.Windows.Input;

namespace WpfAppEditableDeletableCollection
{
    public class Department
    {
       

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
    public class DepartmentDTO
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public ICommand UpdateDept { get; set; }
    }
}