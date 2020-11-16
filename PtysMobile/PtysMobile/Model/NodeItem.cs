using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PtysMobile.Model
{
    public class NodeItem
    {
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public ImageSource MyImageSource
        {
            get
            { //here you decide what resource to use
                return ImageSource.FromResource(ImagePath);
            }
        }
    }
}
