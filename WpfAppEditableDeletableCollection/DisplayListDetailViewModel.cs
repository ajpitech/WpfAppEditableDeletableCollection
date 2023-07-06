using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppEditableDeletableCollection
{
    public class DisplayListDetailViewModel : GenericDisplay
    {
        public DisplayListDetailViewModel(List<object> items) : base(items)
        {
            
        }

        public BaseViewModel ActiveView { get; set; }
      

    }
}
