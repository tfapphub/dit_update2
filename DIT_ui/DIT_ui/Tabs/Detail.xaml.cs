using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIT_ui.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DIT_ui.Tabs
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detail : ContentPage
	{
		public Detail (ÜrünModel model)
		{
			InitializeComponent ();
		    img_ürün.Source = model.fotoUrl;
		    lb_adi.Text = model.ürünAdi;
		    lb_miktar.Text = model.miktar.ToString();
		    lb_gram.Text = model.aciklama.ToString();
		    lb_fiyat.Text = model.fiyat.ToString();
		}
	}
}