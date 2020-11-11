using PtysMobile.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PtysMobile.ViewModel
{
    public class AddRoladyItems
    {
        public ObservableCollection<NodeItem> RoladyItems { get; set; }

        public AddRoladyItems()
        {
            RoladyItems = new ObservableCollection<NodeItem>();
            RoladyItems.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_8150_521x347.png", Name = "Rolada 1", Price = 9.99 });
            RoladyItems.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_8167_521x347.png", Name = "Rolada 2", Price = 9.99 });
            RoladyItems.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_9327_521x348.png", Name = "Rolada 3", Price = 9.99 });
            RoladyItems.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_9328_521x347.png", Name = "Rolada 4", Price = 9.99 });
            RoladyItems.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_9514_521x347.png", Name = "Rolada 5", Price = 9.99 });
            RoladyItems.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_9547_521x347.png", Name = "Rolada 5", Price = 9.99 });
            RoladyItems.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_9595_521x347.png", Name = "Rolada 7", Price = 9.99 });
            RoladyItems.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_9810_521x347.png", Name = "Rolada 8", Price = 9.99 });
        }
    }
}
