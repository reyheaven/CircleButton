using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace DKCircleButton
{
    [BaseType (typeof (UIButton), Name="DKCircleButton")]
    public partial interface CircleButton {
        [Export ("borderColor", ArgumentSemantic.Retain)]
        UIColor BorderColor { get; set; }

        [Export ("animateTap")]
        bool AnimateTap { get; set; }

        [Export ("displayShading")]
        bool DisplayShading { get; set; }

        [Export ("borderSize")]
        float BorderSize { get; set; }

        [Export ("blink")]
        void Blink ();

        [Export ("setImage:animated:")]
        void SetImage (UIImage image, bool animated);
    }
}

