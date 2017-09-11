﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoXaml
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StackLayout : ContentPage
	{
		public StackLayout ()
		{
			InitializeComponent ();
		}

        public object Children { get; internal set; }
    }
}