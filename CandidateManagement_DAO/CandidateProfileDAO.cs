using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidateManagement_BusinessObjects;
using System.Threading.Tasks.Dataflow;

namespace CandidateManagement_DAO
{
    public class CandidateProfileDAO
    {
        private CandidateManagementContext context;
        private static CandidateProfileDAO instance;


        public CandidateProfileDAO()
        {
            context = new CandidateManagementContext();
        }

        public static CandidateProfileDAO getInstance()
        {
            if (instance == null)
            {

                instance = new CandidateProfileDAO();
            }
            return instance;
        }

        public CandidateProfile GetCandidateProfileById(string id)
        {
            return context.CandidateProfiles.SingleOrDefault(m => m.CandidateId.Equals(id));
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return context.CandidateProfiles.Include(jp => jp.Posting).ToList();
        }

        public List<CandidateProfile> GetCandidateProfilesBySearch(string searchText)
        {
            return context.CandidateProfiles.Where(m => (m.CandidateId.Contains(searchText)) || (m.Fullname.Contains(searchText))).Include(jp => jp.Posting).ToList();
        }

        public bool AddCandidateProfile(CandidateProfile candidateProfile)
        {
            bool isSuccess = false;
            CandidateProfile candidateProfile1 = GetCandidateProfileById(candidateProfile.CandidateId);
            try
            {
                if (candidateProfile1 == null)
                {
                    context.CandidateProfiles.Add(candidateProfile);
                    context.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }

        public bool DeleteCandidateProfile(string id)
        {
            bool isSuccess = false;
            CandidateProfile candidateProfile = GetCandidateProfileById(id);
            try
            {
                if (candidateProfile != null)
                {
                    //context.ChangeTracker.Clear();
                    context.CandidateProfiles.Remove(candidateProfile);
                    context.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }

        public bool UpdateCandidateProfile(CandidateProfile candidateProfile)
        {
            bool isSuccess = false;
            CandidateProfile candidateProfile1 = GetCandidateProfileById(candidateProfile.CandidateId);
            try
            {
                if (candidateProfile1 != null)
                {
                    //context.ChangeTracker.Clear();
                    context.Update(candidateProfile);
                    //context.Entry(candidateProfile).State = EntityState.Modified;
                    context.SaveChanges();
                    //context.Entry(candidateProfile).State = EntityState.Detached;
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }
    }
}
