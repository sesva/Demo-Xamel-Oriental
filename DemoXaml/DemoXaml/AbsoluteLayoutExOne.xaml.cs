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
	public partial class AbsoluteLayoutExOne : ContentPage
	{
        int sleepSeconds = 0;
        int waitSeconds = 5;

		public AbsoluteLayoutExOne ()
		{
			InitializeComponent ();

            Device.StartTimer(TimeSpan.FromSeconds(1), () => 
            {
                sleepSeconds++;
                if (sleepSeconds >= waitSeconds)
                {
                    bvOverlayer.IsVisible = false;
                    activityIndicator.IsVisible = false;
                }
                return sleepSeconds < waitSeconds;
            });

		}
	}
}