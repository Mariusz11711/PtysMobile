using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PtysMobile.Model
{
    public class ShoppingCartList
    {
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public ImageSource MyImageSource
        {
            get
            { //here you decide what resource to use
                return ImageSource.FromResource(ImagePath);
            }
        }
    }
}
