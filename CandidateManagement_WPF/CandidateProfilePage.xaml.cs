using CandidateManagement_BusinessObjects;
using CandidateManagement_Services;
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

namespace CandidateManagement_WPF
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class CandidateProfilePage : Page
    {

        private ICandidateProfileService profileServices;
        private IJobPostingService jobPostingServices;

        public CandidateProfilePage()
        {
            InitializeComponent();
            profileServices = new CandidateProfileService();
            jobPostingServices = new JobPostingService();
            //DataContext = this;
        }

        public CandidateProfilePage(int? role)
        {
            InitializeComponent();
            profileServices = new CandidateProfileService();
            jobPostingServices = new JobPostingService();

            switch (role) {
                case 3:
                    CandidateProfileDataGrid.Columns.Remove(CandidateProfileDataGrid.Columns
        .FirstOrDefault(c => c.Header.ToString() == "Actions"));
                    btnAdd.Visibility = Visibility.Collapsed;
                    break;
            }
            
            //DataContext = this;
        }

        private void loadDataInit()
        {
            CandidateProfileDataGrid.ItemsSource = profileServices.ConvertToDtoList(profileServices.GetCandidateProfiles());
        }

        private void btnProfileInfo_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                string id = (string)button.Tag;
                //MessageBox.Show("Info " + id);
                CandidateProfile candidateProfile = profileServices.GetCandidateProfileById(id);
                ViewProfileInfoWindow viewProfileInfoWindow = new ViewProfileInfoWindow(candidateProfile.ProfileShortDescription, candidateProfile.ProfileUrl);
                viewProfileInfoWindow.ShowDialog();
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                string id = (string)button.Tag;
                //MessageBox.Show("Update " + id);
                UpdateCandidateProfileWindow updateCandidateProfileWindow = new UpdateCandidateProfileWindow(id);
                if (updateCandidateProfileWindow.ShowDialog() == true) {
                    loadDataInit();
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                string id = (string)button.Tag;
                //MessageBox.Show("Delete " + id);
                ModalWindow modalWindow = new ModalWindow("Do you really want to delete candidate profile with id " + id + " ?");
                if (modalWindow.ShowDialog() == true)
                {
                    if (profileServices.DeleteCandidateProfile(id))
                    {
                        loadDataInit();
                    } else
                    {
                        MessageBox.Show("Something wrong!");
                    }
                    
                }
            }
        }

        private void CandidateProfilePage_Loaded(object sender, RoutedEventArgs e)
        {
            loadDataInit();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddCandidateProfileWindow addCandidateProfileWindow = new AddCandidateProfileWindow();
            if (addCandidateProfileWindow.ShowDialog() == true)
            {
                loadDataInit();
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string text = txtSearch.Text;
            CandidateProfileDataGrid.ItemsSource = profileServices.ConvertToDtoList(profileServices.GetCandidateProfilesBySearch(text));
        }
    }
}
