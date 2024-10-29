using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidateManagement_BusinessObjects;
using CandidateManagement_DAO;

namespace CandidateManagement_Repository
{
    public class CandidateProfileRepo : ICandidateProfileRepo
    {

        public bool AddCandidateProfile(CandidateProfile candidateProfile) => CandidateProfileDAO.getInstance().AddCandidateProfile(candidateProfile);

        public bool DeleteCandidateProfile(string id) => CandidateProfileDAO.getInstance().DeleteCandidateProfile(id);


        public CandidateProfile GetCandidateProfileById(string id) => CandidateProfileDAO.getInstance().GetCandidateProfileById(id);

        public List<CandidateProfile> GetCandidateProfiles() => CandidateProfileDAO.getInstance().GetCandidateProfiles();

        public List<CandidateProfile> GetCandidateProfilesBySearch(string searchText) => CandidateProfileDAO.getInstance().GetCandidateProfilesBySearch(searchText);

        public bool UpdateCandidateProfile(CandidateProfile candidateProfile) => CandidateProfileDAO.getInstance().UpdateCandidateProfile(candidateProfile);
    }
}
