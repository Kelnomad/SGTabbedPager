using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Core.ViewModels
{
    public abstract class BaseViewModel : MvxViewModel
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { this.SetProperty(ref _title, value); }
        }
    }
}
