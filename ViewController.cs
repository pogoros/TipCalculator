using System;

using UIKit;

namespace TipCalculator
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void BtnCalc_TouchUpInside (UIButton sender)
		{
			double bill = double.Parse(txtAmount.Text);
			double tipp = double.Parse(txtTip.Text);

			double tipv;
			double tipa;

			tipv = (tipp/100) * bill;
			tipa = tipv + bill;

			lblAmount.Text = tipv.ToString("C");
			lblTip.Text = tipa.ToString("C");

		}
	}
}

