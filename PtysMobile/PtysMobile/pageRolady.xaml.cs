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
    }
}