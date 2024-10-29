using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidateManagement_BusinessObjects;

namespace CandidateManagement_DAO
{
    public class JobPostingDAO
    {
        private CandidateManagementContext dbcontext;
        private static JobPostingDAO instance = null;

        public static JobPostingDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JobPostingDAO();
                }
                return instance;
            }
        }

        public JobPostingDAO()
        {
            dbcontext = new CandidateManagementContext();
        }

        public JobPosting GetJobPostingByID(string jobID)
        {
            return dbcontext.JobPostings.SingleOrDefault(m => m.PostingId.Equals(jobID));
        }

        public List<JobPosting> GetJobPostings()
        {
            return dbcontext.JobPostings.ToList();
        }

    }
}
