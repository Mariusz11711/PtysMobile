using PtysMobile.Model;
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
    public partial class pageRolady : ContentPage
    {
        public pageRolady()
        {
            BindingContext = new AddRoladyItems();
            InitializeComponent();
        }

        private async void Button_AddPanel_ClickedAsync(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Waga", "ile sztuk zamawiasz", initialValue: "1", maxLength: 2, keyboard: Keyboard.Numeric);
            var _button = (Button)sender;
            NodeItem temp2 = (NodeItem)_button.CommandParameter;
            Dictionary<string, string> product = new Dictionary<string, string>();
            product.Add("Name", temp2.Name);
            product.Add("Quantity", result);
            product.Add("Price", (temp2.Price * int.Parse(result)).ToString());

            //TODO dodac do koszyka
        }
    }
}