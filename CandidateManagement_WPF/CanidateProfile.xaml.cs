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
using CandidateManagement_BusinessObjects;
using CandidateManagement_Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CandidateManagement_WPF
{
    /// <summary>
    /// Interaction logic for CanidateProfile.xaml
    /// </summary>
    public partial class CanidateProfile : Window
    {
        private ICandidateProfileService profileServices;
        private IJobPostingService jobPostingServices;

        public CanidateProfile()
        {
            InitializeComponent();
            profileServices = new CandidateProfileService();
            jobPostingServices = new JobPostingService();

        }

        public CanidateProfile(int? role)
        {
            InitializeComponent();
            profileServices = new CandidateProfileService();
            jobPostingServices = new JobPostingService();
            switch(role)
            {
                case 1:
                case 2:
                case 4:
                    disableButton();
                    break;

            }
        }

        public void disableButton()
        {
            btnAdd.IsEnabled = false;
        }

       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadDataInit();
        }

        private void loadDataInit() 
        {
            this.dtg_CandidateProfile.ItemsSource = profileServices.GetCandidateProfiles();
            this.cmbPostID.ItemsSource = jobPostingServices.GetJobPostings();
            this.cmbPostID.DisplayMemberPath = "JobPostingTitle";
            this.cmbPostID.SelectedValuePath = "PostingId";

            txtCanidateID.Text = "";
            txtFullName.Text = "";
            //BirthDay = DateTime.Parse(profile.Birthday);
            txtProfileUrl.Text = "";
            cmbPostID.SelectedValue = "";
            txtDescription.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfile candidate = new CandidateProfile();
            candidate.CandidateId = txtCanidateID.Text;
            candidate.Fullname = txtFullName.Text;
            candidate.Birthday = DateTime.Parse(date_birth.Text);
            candidate.ProfileUrl = txtProfileUrl.Text;
            candidate.PostingId = cmbPostID.SelectedValue.ToString();
            candidate.ProfileShortDescription = txtDescription.Text;

            if (profileServices.AddCandidateProfile(candidate))
            {
                MessageBox.Show("Add success");
                loadDataInit();
            }
            else 
            {
                MessageBox.Show("Please contact haudeptrai999");
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            if (row != null)
            {
                DataGridCell RowColumn = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;
                string id = ((TextBlock)RowColumn.Content).Text;
                CandidateProfile profile = profileServices.GetCandidateProfileById(id);
                if (profile != null)
                {
                    txtCanidateID.Text = profile.CandidateId;
                    txtFullName.Text = profile.Fullname;
                    date_birth.Text = profile.Birthday.ToString();
                    //BirthDay = DateTime.Parse(profile.Birthday);
                    txtProfileUrl.Text = profile.ProfileUrl;
                    cmbPostID.SelectedValue = profile.PostingId;
                    txtDescription.Text = profile.ProfileShortDescription;
                }
            }
            
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string candidateID = txtCanidateID.Text;
            if (candidateID.Length > 0 && profileServices.DeleteCandidateProfile(candidateID))
            {
                MessageBox.Show("Delete Successfully!");
                loadDataInit();
            } else
            {
                MessageBox.Show("Something wrong!");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfile candidate = new CandidateProfile();
            candidate.CandidateId = txtCanidateID.Text;
            candidate.Fullname = txtFullName.Text;
            candidate.Birthday = DateTime.Parse(date_birth.Text);
            candidate.ProfileUrl = txtProfileUrl.Text;
            candidate.PostingId = cmbPostID.SelectedValue.ToString();
            candidate.ProfileShortDescription = txtDescription.Text;

            if (profileServices.UpdateCandidateProfile(candidate))
            {
                MessageBox.Show("Update successfully!");
                loadDataInit();
            }
            else
            {
                MessageBox.Show("Please contact haudeptrai999");
            }
        }
    }
}
