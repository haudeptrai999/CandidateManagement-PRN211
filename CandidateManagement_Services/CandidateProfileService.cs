using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidateManagement_BusinessObjects;
using CandidateManagement_Repository;
using CandidateManagement_Services.DTOs;

namespace CandidateManagement_Services
{
    public class CandidateProfileService : ICandidateProfileService
    {
        private ICandidateProfileRepo profileRepo;

        public CandidateProfileService()
        {
            profileRepo = new CandidateProfileRepo();
        }

        public bool AddCandidateProfile(CandidateProfile candidateProfile)
        {
            return profileRepo.AddCandidateProfile(candidateProfile);
        }

        public string getNewId()
        {
            List<CandidateProfile> candidateProfiles = profileRepo.GetCandidateProfiles();
            
            CandidateProfile lastCandidateProfile = candidateProfiles.OrderBy(p => p.CandidateId).LastOrDefault();

            int number = int.Parse(lastCandidateProfile.CandidateId.Substring(9)) + 1;

            return $"CANDIDATE{number:D4}";

        }

        public List<CandidateProfileDTO> ConvertToDtoList(List<CandidateProfile> candidateProfiles)
        {
            List<CandidateProfileDTO> dtoList = new List<CandidateProfileDTO>();

            foreach (CandidateProfile candidateProfile in candidateProfiles)
            {
                CandidateProfileDTO dto = new CandidateProfileDTO();
                dto.CandidateId = candidateProfile.CandidateId;
                dto.Fullname = candidateProfile.Fullname;
                dto.Birthday = candidateProfile.Birthday?.ToString("dd/MM/yyyy");
                dto.JobPostingName = candidateProfile.Posting?.JobPostingTitle;
                dtoList.Add(dto);
            }
            return dtoList;
        }

        public bool DeleteCandidateProfile(string id)
        {
            return profileRepo.DeleteCandidateProfile(id);
        }

        public CandidateProfile GetCandidateProfileById(string id)
        {
            return profileRepo.GetCandidateProfileById(id);
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return profileRepo.GetCandidateProfiles();
        }

        public List<CandidateProfile> GetCandidateProfilesBySearch(string searchText)
        {
            return profileRepo.GetCandidateProfilesBySearch(searchText);
        }

        public bool UpdateCandidateProfile(CandidateProfile candidateProfile)
        {
            return profileRepo.UpdateCandidateProfile(candidateProfile);
        }
    }
}
