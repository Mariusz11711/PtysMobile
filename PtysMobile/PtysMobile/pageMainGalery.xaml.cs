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
    public partial class pageMainGalery : ContentPage
    {
        public pageMainGalery()
        {
            InitializeComponent();
            BindingContext = new AddMainGaleryElements();
        }

        #region buttons
        async void OnButtonTortyClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new pageTorty());
        }
        async void OnButtonTorcikiClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pageTorciki());
        }
        async void OnButtonCiasta_deseroweClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pageCiasta_deserowe());
        }
        async void OnButtonBabkiClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pageBabki());
        }
        async void OnButtonSernikiClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pageSerniki());
        }
        async void OnButtonCiasta_wypiekaneClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pageCiasta_wypiekane());
        }
        async void OnButtonCiastka_bankietoweClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pageCiastka_bankietowe());
        }
        async void OnButtonRoladyClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pageRolady());
        }
        async void OnButtonJablecznikiClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pageJableczniki());
        }

        #endregion
    }
}