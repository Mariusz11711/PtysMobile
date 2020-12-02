using PtysMobile.Model;
using PtysMobile.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PtysMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pageTorty : ContentPage
    {
        AddNodeTorty torty  = new AddNodeTorty();
        public pageTorty()
        {
            
            BindingContext = torty;
            InitializeComponent();
        }


        void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var t2 = this.FindByName<CollectionView>("verticalList");           
            if (e.CurrentSelection.Count > 0)
            {
                string current = (e.CurrentSelection.FirstOrDefault() as NodeTortyEleement)?.NameMenu;               
                switch (current)
                {
                    case "Torty standardowe":
                        gridTorty_standardowe();
                        break;
                    case "Torty lodowe":
                        gridTorty_lodowe();
                        break;
                }

                t2.SetBinding(ItemsView.ItemsSourceProperty, "NodeItemElement"); 
            }
            
        }
        private async void Button_AddPanel_ClickedAsync2(object sender, EventArgs e)
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
        void gridTorty_standardowe()
        {
            torty.NodeItemElement.Clear();
            torty.NodeItemElement.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_8150_521x347.png", Name = "Torty standardowe", Description = "...", Price = 9.99 });
        }
        void gridTorty_lodowe()
        {
            torty.NodeItemElement.Clear();
            torty.NodeItemElement.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_8150_521x347.png", Name = "Torty lodowe", Description = "...", Price = 9.99 });
        }
    }
}