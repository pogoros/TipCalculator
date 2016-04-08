// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TipCalculator
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnCalc { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblAmount { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblTip { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtAmount { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtTip { get; set; }

		[Action ("BtnCalc_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void BtnCalc_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnCalc != null) {
				btnCalc.Dispose ();
				btnCalc = null;
			}
			if (lblAmount != null) {
				lblAmount.Dispose ();
				lblAmount = null;
			}
			if (lblTip != null) {
				lblTip.Dispose ();
				lblTip = null;
			}
			if (txtAmount != null) {
				txtAmount.Dispose ();
				txtAmount = null;
			}
			if (txtTip != null) {
				txtTip.Dispose ();
				txtTip = null;
			}
		}
	}
}
