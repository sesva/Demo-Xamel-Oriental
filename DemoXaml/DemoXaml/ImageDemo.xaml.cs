using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoXaml
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageDemo : ContentPage
	{
		public ImageDemo ()
		{
			InitializeComponent ();

            //image.Source = ImageSource.FromResource("sesva.jpg");
		}
	}
}