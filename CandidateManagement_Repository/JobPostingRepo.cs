using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidateManagement_BusinessObjects;
using CandidateManagement_DAO;

namespace CandidateManagement_Repository
{
    public class JobPostingRepo : IJobPostingRepo
    {
        public JobPosting GetJobPostingById(string jobId) => JobPostingDAO.Instance.GetJobPostingByID(jobId);

        public List<JobPosting> GetJobPostings() => JobPostingDAO.Instance.GetJobPostings();
    }
}
