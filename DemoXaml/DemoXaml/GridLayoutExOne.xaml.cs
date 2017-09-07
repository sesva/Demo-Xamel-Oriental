using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoXaml
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GridLayoutEj1 : ContentPage
	{
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var numberButton = (sender as Button);
            var number = numberButton.Text;

            lblNumber.Text += number;
            //throw new NotImplementedException();
        }

        void Dial_Clicked(object sender, System.EventArgs e)
        {
            //Debug.WriteLine("Dialing {0}...", lblNumber.Text);
            lblNumber.Text = "";
        }

		public GridLayoutEj1 ()
		{
			InitializeComponent ();

		}
	}
}