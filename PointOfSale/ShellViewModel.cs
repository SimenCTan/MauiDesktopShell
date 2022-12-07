using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale;

[INotifyPropertyChanged]
public partial class ShellViewModel
{
    [ObservableProperty]
    bool isFlyoutItemVisable; 
}
