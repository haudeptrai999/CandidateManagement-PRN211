using CandidateManagement_BusinessObjects;
using CandidateManagement_Repository;

namespace CandidateManagement_Services
{
    public class JobPostingService : IJobPostingService
    {
        private readonly IJobPostingRepo jobPostingRepo;

        public JobPostingService()
        {
            jobPostingRepo = new JobPostingRepo();
        }

        public JobPosting GetJobPostingById(string jobId)
        {
            return jobPostingRepo.GetJobPostingById(jobId);
        }

        public List<JobPosting> GetJobPostings()
        {
            return jobPostingRepo.GetJobPostings();
        }
    }
}
