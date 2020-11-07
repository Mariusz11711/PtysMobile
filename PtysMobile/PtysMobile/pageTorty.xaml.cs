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
        public pageTorty()
        {
            BindingContext = new AddNodeTorty();
            InitializeComponent();
        }
    }
}