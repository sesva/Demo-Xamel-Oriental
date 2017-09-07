using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoXaml
{
    
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if (Device.OS == TargetPlatform.Android)
            {

            }else if(Device.OS == TargetPlatform.iOS)
            {

            }

            Padding = new OnPlatform<Thickness>
            {
                Android = new Thickness(0),
                iOS = new Thickness(0,20,0,0)
            };

            /*
            Content = new Button()
            {
                Text = "¡Hola Mundo!",
                TextColor = Color.Aqua,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
            */

            
            
        }
    }
}
