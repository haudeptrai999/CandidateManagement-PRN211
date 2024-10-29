using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidateManagement_BusinessObjects;
using CandidateManagement_Services.DTOs;

namespace CandidateManagement_Services
{
    public interface ICandidateProfileService
    {
        public CandidateProfile GetCandidateProfileById(string id);
        List<CandidateProfile> GetCandidateProfiles();
        List<CandidateProfile> GetCandidateProfilesBySearch(string searchText);
        List<CandidateProfileDTO> ConvertToDtoList(List<CandidateProfile> candidateProfiles);
        public string getNewId();
        public bool AddCandidateProfile(CandidateProfile candidateProfile);
        public bool DeleteCandidateProfile(string id);
        public bool UpdateCandidateProfile(CandidateProfile candidateProfile);
    }
}
