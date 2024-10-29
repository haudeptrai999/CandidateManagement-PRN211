using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidateManagement_BusinessObjects;

namespace CandidateManagement_Repository
{
    public interface ICandidateProfileRepo
    {
        public CandidateProfile GetCandidateProfileById(string id);
        List<CandidateProfile> GetCandidateProfiles();

        public List<CandidateProfile> GetCandidateProfilesBySearch(string searchText);
        public bool AddCandidateProfile(CandidateProfile candidateProfile);
        public bool DeleteCandidateProfile(string id);
        public bool UpdateCandidateProfile(CandidateProfile candidateProfile);

    }
}
