using Avalonia.Controls;
using DevelopmentChallenge.Avalonia;

namespace DevelopmentChallenge.Avalonia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
