using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libDKCircleButton.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, Frameworks = "Foundation UIKit", ForceLoad = true)]