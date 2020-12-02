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
            string result = await DisplayPromptAsync("Liczba", "ile sztuk zamawiasz", initialValue: "1", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!String.IsNullOrEmpty(result))
            {
                var _button = (Button)sender;
                NodeItem commandPar = (NodeItem)_button.CommandParameter;
                Dictionary<string, string> product = new Dictionary<string, string>();
                product.Add("Name", commandPar.Name);
                product.Add("Quantity", result);
                product.Add("Price", (commandPar.Price * int.Parse(result)).ToString());
                product.Add("ImagePath", commandPar.ImagePath);

                Tools.AddTools((object)product);
            }
        }
    }
}