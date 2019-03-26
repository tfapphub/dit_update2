using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIT_ui.Tabs;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DIT_ui.Auth
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
            
		}

	    private async void Btn_login_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new MainPage());
	    }

	    private async void Btn_kayit_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new Signup());
	    }
	}
}