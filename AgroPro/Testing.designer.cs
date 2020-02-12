// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace AgroPro
{
    [Register ("Testing")]
    partial class Testing
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl HomeTabSegmentController { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (HomeTabSegmentController != null) {
                HomeTabSegmentController.Dispose ();
                HomeTabSegmentController = null;
            }
        }
    }
}