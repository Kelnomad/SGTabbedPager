using MvvmCross.iOS.Views;
using System;
using UIKit;

namespace Sample.iOS.Views
{
    public partial class SecondTabView : MvxViewController
    {
        public SecondTabView()
            : base("SecondTabView", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}