using System.Windows;

namespace MusicManager.WpfApp
{

    public partial class TrackWindow : Window
    {
        public TrackWindow()
        {
            InitializeComponent();
            ViewModel.CloseWindow = () => Close();
        }
    }
}
