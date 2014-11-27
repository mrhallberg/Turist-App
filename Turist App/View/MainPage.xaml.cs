using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Turist_App.ViewModel;

namespace Turist_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private OversigtViewModel vm;
        public MainPage()
        {
            this.InitializeComponent();
            vm = new OversigtViewModel();
            DataContext = vm;
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.SelectedOversigt = OversigtViewModel.Kategorier[SelectionBox.SelectedIndex];
        }

        private void Næsteknap_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void Opretbruger_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void Afslut_OnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
