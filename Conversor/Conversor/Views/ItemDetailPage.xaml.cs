using Conversor.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Conversor.Views
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