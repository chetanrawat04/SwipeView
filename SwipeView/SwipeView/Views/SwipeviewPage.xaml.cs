using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwipeView.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SwipeviewPage : ContentPage
	{
		public SwipeviewPage()
		{
			InitializeComponent ();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}