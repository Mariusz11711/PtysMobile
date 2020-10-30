using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PtysMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DebugClass();
            Device.StartTimer(new TimeSpan(0, 0, 4), () =>
            {
                // do something every 4 seconds
                Device.BeginInvokeOnMainThread(() =>
                {
                    // interact with UI elements
                    var greetingImage = this.FindByName<Image>("greeting");
                    greetingImage.Style = (Style)Application.Current.Resources["greetingStyle"];
                });
                return true; // runs again, or false to stop
            });
        }

        //wszystkie obrazy osadzone
        public void DebugClass()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            foreach (var res in assembly.GetManifestResourceNames())
            {
                System.Diagnostics.Debug.WriteLine("found resource: " + res);
            }
        }
    }

    [ContentProperty(nameof(Source))]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }

            // Do your translation lookup here, using whatever method you require
            var imageSource = ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            return imageSource;
        }
    }
}
