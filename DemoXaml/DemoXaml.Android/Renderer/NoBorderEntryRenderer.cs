using System;
using System.Collections.Generic;
using DemoXaml.Controls;
using DemoXaml.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Support.V4.Content;

[assembly: ExportRenderer(typeof(NoBorderEntry), typeof(NoBorderEntryRenderer))]
namespace DemoXaml.Droid.Renderer
{
    class NoBorderEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(e.OldElement != null)
            {

            }
            if (e.NewElement != null)
            {
                this.Control.Background = ContextCompat.GetDrawable(this.Context, Resource.Layout.NoBorderEditText);
                this.Control.Background.Alpha = 0;
                this.Control.Gravity = Android.Views.GravityFlags.Left;
                this.Control.SetPadding(0, 0, 0, 0);
            }
        }
    }
}