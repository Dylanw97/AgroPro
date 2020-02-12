using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace AgroPro
{

    [Register("HomeTab")]
    public class Home : UIViewController
    {
        public Home(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view

            //UILabel asdf = new UILabel();
            //asdf.Text = "";

            //UILabel label = new UILabel();

            //label = new UILabel()
            //{
            //    Text = "Hello, this is a string",
            //    Font = UIFont.FromName("Papyrus", 20f),
            //    TextColor = UIColor.Magenta,
            //    TextAlignment = UITextAlignment.Center
            //};

            //label.AttributedText = new NSAttributedString(
            //    "This is some formatted text",
            //    font: UIFont.FromName("GillSans", 16.0f),
            //    foregroundColor: UIColor.Blue,
            //    backgroundColor: UIColor.White
            //);

            //label.Highlighted = true;
            //label.HighlightedTextColor = UIColor.Cyan;

            //label.ShadowColor = UIColor.Black;
            //label.ShadowOffset = new CoreGraphics.CGSize(1.0f, 1.0f);
        }
    }
}