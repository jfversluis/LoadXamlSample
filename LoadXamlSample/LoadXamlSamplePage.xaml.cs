using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoadXamlSample
{
    public partial class LoadXamlSamplePage : ContentPage
    {
        private int loadCounter = 0;

        public LoadXamlSamplePage()
        {
            InitializeComponent();

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var page = new ContentPage();
            page.LoadFromXaml($"<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n<ContentPage xmlns=\"http://xamarin.com/schemas/2014/forms\"\r\nxmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"\r\nx:Class=\"Examples.Views.TestView\">\r\n<Label Text=\"I was loaded from a string {++loadCounter} times!\" VerticalOptions=\"Center\" HorizontalOptions=\"Center\" />\r\n</ContentPage>");
       
            Navigation.PushAsync(page);
        }
    }
}