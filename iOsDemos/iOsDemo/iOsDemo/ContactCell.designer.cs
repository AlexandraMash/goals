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

namespace iOsDemo
{
    [Register ("ContactCell")]
    partial class ContactCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UILabel NameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIImageView PictureImage { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (NameLabel != null) {
                NameLabel.Dispose ();
                NameLabel = null;
            }

            if (PictureImage != null) {
                PictureImage.Dispose ();
                PictureImage = null;
            }
        }
    }
}