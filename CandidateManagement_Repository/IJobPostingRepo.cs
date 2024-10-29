using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidateManagement_BusinessObjects;

namespace CandidateManagement_Repository
{
    public interface IJobPostingRepo
    {
        public JobPosting GetJobPostingById(string jobId);

        public List<JobPosting> GetJobPostings();
    }
}
