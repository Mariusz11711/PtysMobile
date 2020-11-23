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
    public partial class pageShoppingCart : ContentPage
    {

        public pageShoppingCart()
        {
            AddShoppingCartNode cartNode = createBindingSource();

            BindingContext = cartNode;

            Button button = new Button
            {
                Text = "Navigate!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            InitializeComponent();
            Content = AddCartElement();

        }

        private AddShoppingCartNode createBindingSource()
        {
            AddShoppingCartNode cartNode = new AddShoppingCartNode();

            foreach (Dictionary<string, string> item in Tools.GetTools())
            {
                cartNode.CartList.Add(new ShoppingCartList() { Name = item["Name"], Quantity = item["Quantity"], ImagePath = item["ImagePath"], Price = item["Price"] });
            }

            return cartNode;
        }

        private CollectionView AddCartElement()
        {
            Button button = new Button { Text = "BACK TO SHOPPING" };
            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new pageMainGalery2());
            };
            Button button2 = new Button { Text = "Zapłac" };
            button2.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new pageMainGalery2());
            };

            CollectionView collectionView = new CollectionView
            {
                ItemsLayout = LinearItemsLayout.Vertical,

                Header = new StackLayout
                {
                    Children =
                    {
                        button
                    }
                },
                Footer = new StackLayout
                {
                    Children =
                {
                         button2
                    }
                }
            };

            collectionView.SetBinding(ItemsView.ItemsSourceProperty, "CartList");
           

            collectionView.ItemTemplate = new DataTemplate(() =>
            {
                Grid grid = new Grid { Padding = 10, BackgroundColor = Color.White };
                grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

                Image image = new Image { Aspect = Aspect.AspectFill, HeightRequest = 90, WidthRequest = 90 };
                image.SetBinding(Image.SourceProperty, "MyImageSource");

                Label nameLabel = new Label { FontAttributes = FontAttributes.Italic, VerticalOptions = LayoutOptions.End };
                nameLabel.SetBinding(Label.TextProperty, "Name");
                
                Label quantityLabel = new Label { FontAttributes = FontAttributes.Italic, VerticalOptions = LayoutOptions.End };
                quantityLabel.SetBinding(Label.TextProperty, "Quantity");
                
                Label priceLabel = new Label { FontAttributes = FontAttributes.Italic, VerticalOptions = LayoutOptions.End };
                priceLabel.SetBinding(Label.TextProperty, "Price");

                Grid.SetRowSpan(image, 3);
  

                grid.Children.Add(image);
                
    
                grid.Children.Add(nameLabel, 1, 0);
                grid.Children.Add(quantityLabel, 1, 1);
                grid.Children.Add(priceLabel, 1, 2);

                return grid;

                //https://docs.microsoft.com/pl-pl/xamarin/xamarin-forms/user-interface/collectionview/populate-data
                //SwipeView swipeView = new SwipeView();
                //SwipeItem deleteSwipeItem = new SwipeItem
                //{
                //    Text = "Delete",
                //    IconImageSource = "1-LOGO.jpg",
                //    BackgroundColor = Color.LightPink
                //};
                //deleteSwipeItem.SetBinding(MenuItem.CommandProperty, new Binding("BindingContext.DeleteCommand", source: collectionView));
                //deleteSwipeItem.SetBinding(MenuItem.CommandParameterProperty, ".");

                //swipeView.LeftItems = new SwipeItems { deleteSwipeItem };
                //swipeView.Content = grid;
                //return swipeView;

            });

            return collectionView;
        }

        async private void Button_Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pageMainGalery2());
        }

        async private void Button_Payment_Clicked(object sender, EventArgs e)
        {

        }
    }
}