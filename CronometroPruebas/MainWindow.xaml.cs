using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CronometroPruebas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Segundos = 0;
        DispatcherTimer dt = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += tickevent;
            txtSegundos.Text = Segundos.ToString();
        }

        private void btnArrancar_Click(object sender, RoutedEventArgs e)
        {
            dt.Start();
        }

        private void tickevent(object sender, EventArgs e)
        {
            Segundos++;
            txtSegundos.Text = Segundos.ToString();
        }
        private void btnPausar_Click(object sender, RoutedEventArgs e)
        {
            dt.Stop();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            Segundos = 0;
            txtSegundos.Text = Segundos.ToString();
            dt.Stop();
        }
    }
}