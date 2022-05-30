using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI;
using Avalonia.Reactive;
using RGRAvalonia.ViewModels;

namespace RGRAvalonia.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }
        private void CreateQuery(object sender, RoutedEventArgs e)
        {
            new QueryWindow().Show((Window)this.VisualRoot);
        }
    }
}
