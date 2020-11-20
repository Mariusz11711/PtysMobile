using PtysMobile.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PtysMobile.ViewModel
{
    public class AddShoppingCartNode
    {
        public ObservableCollection<ShoppingList> NodeShoppingList { get; set; }

        public AddShoppingCartNode()
        {
            NodeShoppingList = new ObservableCollection<ShoppingList>();
            NodeShoppingList.Add(new ShoppingList() { ImagePath = "PtysMobile.Images.Rolady._MG_8150_521x347.png", Name = "Rolada 1", Price = 9.99 });
        }
    }
}
