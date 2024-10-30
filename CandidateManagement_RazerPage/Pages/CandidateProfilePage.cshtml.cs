using CandidateManagement_BusinessObjects;
using CandidateManagement_Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;

namespace CandidateManagement_RazerPage.Pages
{
    public class CandidateProfilePageModel : PageModel
    {
        private ICandidateProfileService profileServices;
        private IJobPostingService jobPostingServices;


        [BindProperty]
        public List<CandidateProfile> candidateProfiles {  get; set; }

        [BindProperty]
        public List<JobPosting> jobPosts { get; set; }

        [BindProperty]
        public CandidateProfile updateProfile { get; set; }
        [BindProperty]
        public CandidateProfile addProfile { get; set; }
        [BindProperty]
        public int role { get; set; }

        public string test {  get; set; }

        public CandidateProfilePageModel()
        {
            profileServices = new CandidateProfileService();
            jobPostingServices = new JobPostingService();
        }

        public void OnGet(int role)
        {
            candidateProfiles = profileServices.GetCandidateProfiles();
            jobPosts = jobPostingServices.GetJobPostings();
            this.role = role;
        }

        public void OnPostDeleteCandidateProfile(string deleteId)
        {
            profileServices.DeleteCandidateProfile(deleteId);
            candidateProfiles = profileServices.GetCandidateProfiles();
            updateProfile = null;
            jobPosts = jobPostingServices.GetJobPostings();

            //return RedirectToPage();
        }

        public void OnPostUpdateCandidateProfileModal(string updateId)
        {
            updateProfile = profileServices.GetCandidateProfileById(updateId);
            candidateProfiles = profileServices.GetCandidateProfiles();
            jobPosts = jobPostingServices.GetJobPostings();
        }

        public IActionResult OnPostUpdateCandidateProfile()
        {
            profileServices.UpdateCandidateProfile(updateProfile);
            candidateProfiles = profileServices.GetCandidateProfiles();
            jobPosts = jobPostingServices.GetJobPostings();

            return RedirectToPage(new { role = this.role });
        }

        public IActionResult OnPostAddCandidateProfile()
        {
            addProfile.CandidateId = profileServices.getNewId();
            profileServices.AddCandidateProfile(addProfile);
            candidateProfiles = profileServices.GetCandidateProfiles();
            jobPosts = jobPostingServices.GetJobPostings();

            return RedirectToPage(new { role = this.role  });
        }


    }

     
}
