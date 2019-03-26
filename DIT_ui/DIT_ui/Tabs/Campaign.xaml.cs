using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DIT_ui.Tabs
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Campaign : ContentPage
	{
		public Campaign ()
		{
			InitializeComponent ();
		}

	    private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
	    {
	       
	    }
	}
}