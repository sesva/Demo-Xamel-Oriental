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
    public partial class EntryDemo : ContentPage
    {
        private void Handle_Completed(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            var entry = sender as Entry;
            Debug.WriteLine("La entra es : {0}", entry.Text);
        }


        private void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            Debug.WriteLine("La entrada es : {0}", e.NewTextValue);
        }

        public EntryDemo()
        {
            InitializeComponent();
        }

        private void Entry_Completed(object sender, EventArgs e)
        {

        }

        private void Entry_Completed_1(object sender, EventArgs e)
        {

        }
    }
}