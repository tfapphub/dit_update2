using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DIT_ui.Models
{
    public class UrunListe
    {
       public ObservableCollection<ÜrünModel> Urünler { get; set; }

        public UrunListe()
        {
            Urünler = new ObservableCollection<ÜrünModel>
            {
                new ÜrünModel {ürünBarkod="8695077061751",ürünAdi = "eti cin", aciklama = "24gr.", miktar = 2, fotoUrl = "https://cdn.cimri.io/image/240x240/eticingrportakallbiskvi_47585431.jpg",fiyat=0.5},
                new ÜrünModel {ürünBarkod="8695077061752",ürünAdi = "alo deterjan", aciklama = "3Lt.", miktar = 1, fotoUrl = "https://cdn.akakce.com/alo/alo-kar-cicegi-33-yikama-2-14-lt-beyazlar-icin-z.jpg",fiyat=24.75},
                new ÜrünModel {ürünBarkod="8695077061753",ürünAdi = "çilekli link", aciklama = "330ml.", miktar = 3, fotoUrl = "https://cdnd.bizimtoptan.com.tr/product/480x480/0000152-0.11235500-link-cilek-aromali-icecek-200-ml-15-adet.png",fiyat=2.25},
                new ÜrünModel {ürünBarkod="8695077061754",ürünAdi = "uno çok tahıllı", aciklama = "460gr.", miktar = 1, fotoUrl = "https://online.yunusmarket.com.tr/1094-large_default/uno-premium-cok-tahilli-ekmek-460-gr.jpg",fiyat=3},
                new ÜrünModel {ürünBarkod="8695077061755",ürünAdi = "eti cin", aciklama = "24gr.", miktar = 2, fotoUrl = "https://cdn.cimri.io/image/240x240/eticingrportakallbiskvi_47585431.jpg",fiyat=0.5},
                new ÜrünModel {ürünBarkod="8695077061756",ürünAdi = "alo deterjan", aciklama = "3Lt.", miktar = 1, fotoUrl = "https://cdn.akakce.com/alo/alo-kar-cicegi-33-yikama-2-14-lt-beyazlar-icin-z.jpg",fiyat=24.75},
                new ÜrünModel {ürünBarkod="8695077061757",ürünAdi = "çilekli link", aciklama = "330ml.", miktar = 3, fotoUrl = "https://cdnd.bizimtoptan.com.tr/product/480x480/0000152-0.11235500-link-cilek-aromali-icecek-200-ml-15-adet.png",fiyat=2.25},
                new ÜrünModel {ürünBarkod="8695077061758",ürünAdi = "uno çok tahıllı", aciklama = "460gr.", miktar = 1, fotoUrl = "https://online.yunusmarket.com.tr/1094-large_default/uno-premium-cok-tahilli-ekmek-460-gr.jpg",fiyat=3},
            };
        }
    }
}
