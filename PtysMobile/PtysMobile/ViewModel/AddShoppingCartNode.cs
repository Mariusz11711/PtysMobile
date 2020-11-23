using PtysMobile.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PtysMobile.ViewModel
{
    public class AddShoppingCartNode
    {
        public ObservableCollection<ShoppingCartList> CartList { get; set; }

        public AddShoppingCartNode()
        {
            CartList = new ObservableCollection<ShoppingCartList>();
        }
    }
}
