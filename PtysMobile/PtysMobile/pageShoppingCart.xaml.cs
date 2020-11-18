using PtysMobile.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PtysMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pageShoppingCart : ContentPage
    {
        public pageShoppingCart()
        {
            BindingContext = new AddShoppingCartNode();
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pageMainGalery2());
        }
    }
}