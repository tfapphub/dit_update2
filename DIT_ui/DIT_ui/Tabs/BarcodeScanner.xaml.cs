using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIT_ui.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace DIT_ui.Tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarcodeScanner : ContentPage
    {
        ZXingScannerPage scanPage;
        public BarcodeScanner()
        {
            InitializeComponent();
        }

        public async Task getScanner()
        {
            scanPage = new ZXingScannerPage();
            scanPage.Title = "Barkod Okuyucu";
            scanPage.OnScanResult += (result) =>
            {
                scanPage.IsScanning = false;
                Device.BeginInvokeOnMainThread(() =>
                {
                    UrunListe ürün = new UrunListe();
                    ÜrünModel model= ürün.Urünler.Where(r => r.ürünBarkod == result.Text).First();
                    Navigation.PushAsync(new Detail(model));

                });
            };
            await Navigation.PushAsync(scanPage);
        }

        private void Btn_getwithcode_OnClicked(object sender, EventArgs e)
        {
            this.DisplayAlert("Geçici", "Bu kısımda kodu okuyup ürünü döndürmesi bekleniyor.", "Tamam");
        }

        private async void Btn_openscanner_OnClicked(object sender, EventArgs e)
        {
            await getScanner();
        }
    }
}