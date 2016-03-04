using MvvmCross.iOS.Views;
using System;
using UIKit;
using DK.Ostebaronen.Touch.SGTabbedPager;
using Sample.Core.ViewModels;
using System.Collections.Generic;
using ObjCRuntime;
using System.Linq;

namespace Sample.iOS.Views
{
    public partial class TabHostView : MvxSGTabbedPager<TabHostViewModel>, ISGTabbedPagerDatasource, ISGTabbedPagerDelegate
    {

        private static readonly List<UIViewController> _tabs = new List<UIViewController>();

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            if (RespondsToSelector(new Selector("setEdgesForExtendedLayout:"))) 
                EdgesForExtendedLayout = UIRectEdge.None;


            Datasource = this;
            TabColor = UIColor.FromRGB(147, 192, 31);
            HeaderFont = UIFont.SystemFontOfSize(15);
            HeaderColor = UIColor.DarkGray;
            BottomLineColor = UIColor.White;
        }

        public int NumberOfViewControllers
        {
            get { return ViewModel.TabsVM.Count; }
        }

        public UIViewController GetViewController(int page)
        {
            if(!_tabs.Any())
            {
                foreach (var vm in ViewModel.TabsVM)
                {
                    var tab = this.CreateViewControllerFor(vm) as UIViewController;
                    tab.Title = ((BaseViewModel)vm).Title;
                    _tabs.Add(tab);
                }
            }
            return _tabs[page];
        }

        public string GetViewControllerTitle(int page)
        {
            return _tabs[page].Title;
        }

        public void DidShowViewController(int page)
        {
            Console.WriteLine(String.Format("Did show {0}", page));
        }
    }
}