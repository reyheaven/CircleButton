using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using DKCircleButton;

namespace Sample
{
    public class MainViewController : UIViewController
    {
        UIButton startButton;
        UIButton stopButton;

        public MainViewController()
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.FromRGB(.29f, .59f, .81f);

            startButton = new CircleButton();
            startButton.Frame = new RectangleF(0, 0, 90, 90);
            startButton.Center = new PointF(160, 200);

            startButton.Font = UIFont.SystemFontOfSize(22);

            startButton.SetTitle("Start", UIControlState.Normal); 
            startButton.SetTitleColor(UIColor.White, UIControlState.Normal);

            startButton.TouchUpInside += (sender, e) => {

            };

            View.Add(startButton); 
        }
    }
}