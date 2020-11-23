using System;
using System.Collections.Generic;
using System.Text;

namespace PtysMobile
{
    public static class Tools
    {
        static List<object> itemList = new List<object>();
        static double priceSum;

        public static void AddTools(Object item)
        {
            //TODO sum price
            itemList.Add(item);
        }
        
        public static List<object> GetTools()
        {
            return itemList;
        }
    }
}
