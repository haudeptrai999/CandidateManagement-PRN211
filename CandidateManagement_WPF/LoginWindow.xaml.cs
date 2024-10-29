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
using CandidateManagement_WPF;
using CandidateManagement_BusinessObjects;
using CandidateManagement_Services;

namespace CandidateManagement_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private IHRAccountService hRAccountService;
        public LoginWindow()
        {
            InitializeComponent();
            hRAccountService = new HRAccountService();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            DragMove();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Hraccount hraccount = hRAccountService.GetHraccountByEmail(txtEmail.Text);
            if (hraccount != null && hraccount.Password.Equals(txtPassword.Password))
            {
                //MessageBox.Show("Hello haudeptrai999!");
                //CanidateProfile canidateProfile = new CanidateProfile(hraccount.MemberRole);
                MainWindow mainTestWindow = new MainWindow(hraccount.MemberRole);
                Close();
                mainTestWindow.Show();
                //canidateProfile.Show();
            }
            else
            {
                MessageBox.Show("Bye bye!");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainTestWindow = new MainWindow();
            mainTestWindow.Show();
        }

        private void btnTest1_Click(object sender, RoutedEventArgs e)
        {
            AddCandidateProfileWindow addCandidateProfileWindow = new AddCandidateProfileWindow();
            addCandidateProfileWindow.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}