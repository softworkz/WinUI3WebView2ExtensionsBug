namespace WinUI3WebView2ExtensionsBug
{
    using Microsoft.UI.Xaml;
    using Microsoft.Web.WebView2.Core;

    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            var options = new CoreWebView2EnvironmentOptions();
            options.AdditionalBrowserArguments = "--enable-disble ";
            options.AreBrowserExtensionsEnabled = true;

            myButton.Content = "Clicked";
        }
    }
}
