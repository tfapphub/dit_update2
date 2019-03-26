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
	public partial class Signup : ContentPage
	{
		public Signup ()
		{
			InitializeComponent ();
		}

	    private async void kaydol_onclick(object sender, EventArgs e)
	    {
	       await tamam_onclick();
	    }

	    public async Task tamam_onclick()
	    {
	        var action = await DisplayAlert("Kayıt Onay", "Sisteme başarılı bir şekilde kaydoldunuz.", "Giriş Yap", "Geri");
	        if (action)
	        {
	          await Navigation.PushAsync(new MainPage());
	        }
	        else
	        {
	          await Navigation.PopAsync();
	        }
	    }
	}
}