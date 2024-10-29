using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidateManagement_BusinessObjects;

namespace CandidateManagement_Services
{
    public interface IJobPostingService
    {
        public JobPosting GetJobPostingById(string jobId);
        public List<JobPosting> GetJobPostings();
    }
}
