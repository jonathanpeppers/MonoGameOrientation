using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace PortraitControllerInLandscapeGame
{
    public class PortraitController : UIViewController
    {
        public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations()
        {
            return UIInterfaceOrientationMask.Portrait;
        }

        public override bool ShouldAutorotate()
        {
            return true;
        }

        [Obsolete ("Deprecated in iOS6. Replace it with both GetSupportedInterfaceOrientations and PreferredInterfaceOrientationForPresentation")]
        public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
        {
            return toInterfaceOrientation == UIInterfaceOrientation.Portrait;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.AutoresizingMask = UIViewAutoresizing.All;

            var label = new UILabel(View.Frame);
            label.Text = "Tap me to dismiss.";
            label.TextAlignment = UITextAlignment.Center;
            View.AddSubview(label);
        }

        public override void TouchesEnded(NSSet touches, UIEvent evt)
        {
            base.TouchesEnded(touches, evt);

            DismissViewController(true, null);
        }
    }
}

