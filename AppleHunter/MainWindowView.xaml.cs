namespace AppleHunter
{
    using System.Windows;

    internal partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            this.DataContext = new MainWindowViewModel();

            InitializeComponent();
        }
    }
}