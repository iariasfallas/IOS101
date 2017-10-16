using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using CoreGraphics;

namespace TipCalculator
{
    class MyViewController : UIViewController
    {
        public MyViewController()
        {
            
        }

        /// <summary>
        /// Override the method.
        /// Add the controls
        /// </summary>
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // or this.
            View.BackgroundColor = UIColor.LightGray;

            UITextField totalAmount = new UITextField()
            {
                Frame = new CGRect(20, 28, View.Bounds.Width - 40, 35),
                KeyboardType = UIKeyboardType.DecimalPad,
                BorderStyle = UITextBorderStyle.RoundedRect,
                Placeholder = "Enter Total Amount"
            };

            UIButton calcButton = new UIButton(UIButtonType.Custom)
            {
                Frame = new CGRect(
                    20, 71, View.Bounds.Width - 40, 45),
                BackgroundColor = UIColor.FromRGB(0f, 0.5f, 0f)
            };

            calcButton.SetTitle("Calculate", UIControlState.Normal);

            UILabel resultLabel = new UILabel()
            {
                Frame = new CGRect(
                    x: 20, y: 124, width: View.Bounds.Width - 40, height: 40),
                TextColor = UIColor.Blue,
                TextAlignment = UITextAlignment.Center,
                Font = UIFont.SystemFontOfSize(24),
                Text = "Tip is $0.00"
            };

            View.AddSubviews(totalAmount, calcButton, resultLabel);

        }
    }
}