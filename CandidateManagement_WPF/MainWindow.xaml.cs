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
using System.Windows.Shapes;

namespace CandidateManagement_WPF
{
    /// <summary>
    /// Interaction logic for MainTestWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int? roleProfile;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(int? role)
        {
            InitializeComponent();
            roleProfile = role;
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }

        private void navManageCandidateProfile_Checked(object sender, RoutedEventArgs e)
        {
            ViewController.Navigate(new CandidateProfilePage(roleProfile));
        }

        private void navManageJobPosting_Checked(object sender, RoutedEventArgs e)
        {
            ViewController.Navigate(new JobPostingPage());
        }

        private void navManageHRAccount_Checked(object sender, RoutedEventArgs e)
        {
            ViewController.Navigate(new HRAccountPage());
        }

        private void MainTestWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ViewController.Navigate(new CandidateProfilePage(roleProfile));
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
