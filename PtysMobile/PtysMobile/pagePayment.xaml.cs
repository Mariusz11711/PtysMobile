using Android.Content.PM;
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
    public partial class pagePayment : ContentPage
    {
        public pagePayment()
        {
            InitializeComponent();
        }

        private void PayViaGooglePay()
        {
            if (IsGooglePayInstaled())
            {

            }
        }

        private bool IsGooglePayInstaled()
        {
            
           // PackageManager pm = this.PackageMenager;
            return false;
        }

        private void CheckOut_Clicked(object sender, EventArgs e)
        {
            //var judo = new Judo
            //{
            //    JudoId = "<JUDO_ID>",
            //    Token = "<API_TOKEN>",
            //    Secret = "<API_SECRET>",
            //    Environment = JudoEnvironment.Sandbox,
            //    Amount = 1.50m,
            //    Currency = "GBP",
            //    ConsumerReference = "YourUniqueReference"
            //};

            //var paymentJudoPage = new PaymentPage(judo);
            //Navigation.PushAsync(paymentJudoPage);
            //paymentJudoPage.resultHandler += Handler;
        }

        //private async void Handler(object sender, IResult<ITransactionResult> e)
        //{
        //    await Navigation.PopAsync();

        //    if (e.HasError)
        //    {
        //        await DisplayAlert("Payment error", "Code: " + e.Error.Code, "OK");
        //    }
        //    else if ("Success".Equals(e.Response.Result))
        //    {
        //        await DisplayAlert("Payment successful", "Recipt ID: " + e.Response.ReciptId, "OK");
        //    }
        //}
    }
}