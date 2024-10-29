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
    /// Interaction logic for ViewProfileInfoWindow.xaml
    /// </summary>
    public partial class ViewProfileInfoWindow : Window
    {
        public ViewProfileInfoWindow()
        {
            InitializeComponent();
        }

        public ViewProfileInfoWindow(string profileShortDescription, string profileURL)
        {
            InitializeComponent();
            txtProfileShortDescription.Text = profileShortDescription;
            txtProfileURL.Text = profileURL;
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
