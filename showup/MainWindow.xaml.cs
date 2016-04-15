using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace showup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MainWindow()
        {
            log.Debug(":::: 프로그램 시작 :::");
            InitializeComponent();
            log.Debug(":::: 콤포넌트 등록 완료 :::");
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.WindowState = WindowState.Maximized;
        }
    }
}
