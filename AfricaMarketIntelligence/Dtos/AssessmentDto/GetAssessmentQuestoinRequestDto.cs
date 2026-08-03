using AfricaMarketIntelligence.Dtos.CommonDto;

namespace AfricaMarketIntelligence.Dtos.AssessmentDto
{
    public class GetAssessmentQuestoinRequestDto : PaginationRequest
    {
        public int AssessmentID { get; set; } 
        public int? PillarID { get; set; }
    }
}
