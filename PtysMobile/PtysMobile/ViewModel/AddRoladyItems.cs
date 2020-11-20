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
            RoladyItems.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_8150_521x347.png", Name = "ROLADA JAGODOWA", Description = "...", Price = 9.99 });
            RoladyItems.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_8167_521x347.png", Name = "ROLADA JOGURTOWA", Description = "...", Price = 9.99 });
            RoladyItems.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_9327_521x348.png", Name = "ROLADA ORZECH LASKOWY", Description = "...", Price = 9.99 });
            RoladyItems.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_9328_521x347.png", Name = "ROLADA Z BITĄ ŚMIETANĄ", Description = "...", Price = 9.99 });
            RoladyItems.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_9514_521x347.png", Name = "ROLADA STRACCIATELLA", Description = "...", Price = 9.99 });
            RoladyItems.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_9547_521x347.png", Name = "ROLADA TRUSKAWKOWA", Description = "...", Price = 9.99 });
            RoladyItems.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_9595_521x347.png", Name = "ROLADA ORZECH WŁOSKI", Description = "...", Price = 9.99 });
            RoladyItems.Add(new NodeItem() { ImagePath = "PtysMobile.Images.Rolady._MG_9810_521x347.png", Name = "ROLADA BEZOWA", Description = "...", Price = 9.99 });
        }
    }
}
