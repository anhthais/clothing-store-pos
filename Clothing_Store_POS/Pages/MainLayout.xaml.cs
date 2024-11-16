using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Clothing_Store_POS.Pages.Products;
using Clothing_Store_POS.Pages.Users;
using Clothing_Store_POS.Pages.Home;
using Clothing_Store_POS.Pages.Auth;
using Clothing_Store_POS.Pages.Customers;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Clothing_Store_POS.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainLayout : Page
    {
        public MainLayout()
        {
            this.InitializeComponent();
            this.MainContent.Navigate(typeof(HomePage));
        }

        private void navigation_Selected(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {

        }

        // handle page selected event
        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            string selectedTag = args.InvokedItemContainer.Tag.ToString();

            switch (selectedTag) {
                case "home":
                    this.MainContent.Navigate(typeof(HomePage));
                    break;
                case "products":
                    this.MainContent.Navigate(typeof(ProductPage));
                    break;
                case "users":
                    this.MainContent.Navigate(typeof(UserPage));
                    break;
                case "customers":;
                    this.MainContent.Navigate(typeof(CustomerPage));
                    break;
            }
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LoginPage));
        }
    }
}
