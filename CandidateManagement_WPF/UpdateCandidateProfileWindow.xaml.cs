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
using System.Windows.Shapes;

namespace CandidateManagement_WPF
{
    /// <summary>
    /// Interaction logic for UpdateCandidateProfileWindow.xaml
    /// </summary>
    public partial class UpdateCandidateProfileWindow : Window
    {

        private ICandidateProfileService profileServices;
        private IJobPostingService jobPostingServices;
        private string idUpdate;

        public UpdateCandidateProfileWindow(string id)
        {
            InitializeComponent();
            profileServices = new CandidateProfileService();
            jobPostingServices = new JobPostingService();
            idUpdate = id;
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (txtFullName.Text.Length == 0 || dpBirthDay.Text.Length == 0 || txtProfileUrl.Text.Length == 0 || cmbPostID.SelectedValue.ToString().Length == 0 || txtDescription.Text.Length == 0)
            {
                MessageBox.Show("Please fill all the details");
            }
            else
            {
                CandidateProfile candidate = new CandidateProfile();
                candidate.CandidateId = idUpdate;
                candidate.Fullname = txtFullName.Text;
                candidate.Birthday = DateTime.Parse(dpBirthDay.Text);
                candidate.ProfileUrl = txtProfileUrl.Text;
                candidate.PostingId = cmbPostID.SelectedValue.ToString();
                candidate.ProfileShortDescription = txtDescription.Text;

                if (profileServices.UpdateCandidateProfile(candidate))
                {
                    this.DialogResult = true;
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Please contact haudeptrai999");
                }

            }
        }

        private void UpdateCandidateProfile_Loaded(object sender, RoutedEventArgs e)
        {
            this.cmbPostID.ItemsSource = jobPostingServices.GetJobPostings();
            this.cmbPostID.DisplayMemberPath = "JobPostingTitle";
            this.cmbPostID.SelectedValuePath = "PostingId";

            CandidateProfile profile = profileServices.GetCandidateProfileById(idUpdate);

            txtCandidateID.Content = txtCandidateID.Content + profile.CandidateId;
            txtFullName.Text = profile.Fullname;
            dpBirthDay.Text = profile.Birthday.ToString();
            txtProfileUrl.Text = profile.ProfileUrl;
            cmbPostID.SelectedValue = profile.PostingId;
            txtDescription.Text = profile.ProfileShortDescription;
        }
    }
}
