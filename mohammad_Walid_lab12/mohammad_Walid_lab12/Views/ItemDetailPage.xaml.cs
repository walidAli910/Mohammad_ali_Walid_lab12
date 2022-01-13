using mohammad_Walid_lab12.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace mohammad_Walid_lab12.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}