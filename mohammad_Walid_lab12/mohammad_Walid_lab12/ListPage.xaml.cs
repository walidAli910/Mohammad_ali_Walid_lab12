using mohammad_Walid_lab12.Droid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mohammad_Walid_lab12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            async void OnSaveButtonClicked(object sender, EventArgs e)
            {
                var slist = (ShopList)BindingContext;
                slist.Date = DateTime.UtcNow;
                await App.Database.SaveShopListAsync(slist);
                await Navigation.PopAsync();
            }
            async void OnDeleteButtonClicked(object sender, EventArgs e)
            {
                var slist = (ShopList)BindingContext;
                await App.Database.DeleteShopListAsync(slist);
                await Navigation.PopAsync();
            }
            InitializeComponent();
        }
    }
}