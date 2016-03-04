using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System.Collections.Generic;

namespace Sample.Core.ViewModels
{
    public class TabHostViewModel
        : BaseViewModel
    {


        public void Init()
        {
            var viewModelLoader = Mvx.Resolve<IMvxViewModelLoader>();
            TabsVM = new List<IMvxViewModel> 
            {
                viewModelLoader.LoadViewModel(new MvxViewModelRequest(typeof(FirstTabViewModel),null, null, null),null),
                viewModelLoader.LoadViewModel(new MvxViewModelRequest(typeof(SecondTabViewModel),null, null, null),null)
            }; 

        }

        private List<IMvxViewModel> _tabsVM;
        public List<IMvxViewModel> TabsVM
        {
            get { return _tabsVM; }
            set { this.SetProperty(ref _tabsVM, value); }
        }

    }
}
