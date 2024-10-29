namespace CandidateManagement_Services.DTOs
{
    public class CandidateProfileDTO
    {
        public string CandidateId { get; set; } = null!;
        public string Fullname { get; set; } = null!;
        public string? Birthday { get; set; }
        public string? JobPostingName { get; set; }
    }
}