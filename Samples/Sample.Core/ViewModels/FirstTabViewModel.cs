using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Core.ViewModels
{
    public class FirstTabViewModel : BaseViewModel
    {
        private string _hello = "Hello From first tab !";
        public string Hello
        {
            get { return _hello; }
            set { SetProperty(ref _hello, value); }
        }
    }
}
