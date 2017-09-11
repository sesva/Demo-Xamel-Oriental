using Xamarin.Forms;
using DemoXaml.Controls;
using DemoXaml.iOS.Renderer;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NoBorderEntry), typeof(NoBorderEntryRenderer))]
namespace DemoXaml.iOS.Renderer
{
    class NoBorderEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(e.OldElement != null)
            {

            }
            if(e.NewElement != null)
            {
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
            }
        }
    }
}