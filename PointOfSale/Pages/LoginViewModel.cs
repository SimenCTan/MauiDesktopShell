using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Pages;

[INotifyPropertyChanged]
public partial class LoginViewModel
{
    [ObservableProperty]
    bool isLogin;
}
