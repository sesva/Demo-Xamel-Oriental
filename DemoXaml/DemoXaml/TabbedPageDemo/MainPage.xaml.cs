
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoXaml.TabbedPageDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : TabbedPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}
	}
}