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
	public partial class Cart : ContentPage
	{
		public Cart ()
		{
			InitializeComponent ();
		    lv_ürün.ItemsSource = GetUrünler();
		}

	    private void Btn_güncelle_OnClicked(object sender, EventArgs e)
	    {
	        this.DisplayAlert("Güncelle", "Miktar Giriniz", "Güncelle");
	    }

	    private void Btn_sil_OnClicked(object sender, EventArgs e)
	    {
	        this.DisplayAlert("Sil", "Ürünü listenizden kaldırmak istediğinizden emin misiniz?", "Kaldır", "İptal");
	    }

	    private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
	    {
	     
	    }

	    private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
	    {
	      lv_ürün.ItemsSource=GetUrünler(e.NewTextValue);
	    }

	    IEnumerable<ÜrünModel> GetUrünler(string search = null)
	    {
            UrunListe ürün = new UrunListe();
            if (String.IsNullOrWhiteSpace(search))
            {
                return ürün.Urünler;
            }

	        return ürün.Urünler.Where(u => u.ürünAdi.Contains(search));
	    }

	    private void Btn_ok_OnClicked(object sender, EventArgs e)
	    {
	        this.DisplayAlert("Tamamla", "Alışverişinizi tamamlamak istiyor musunuz?", "Evet","Alışverişe devam et");
        }

	    private async void Btn_addCart_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new BarcodeScanner());
	    }
	}
}