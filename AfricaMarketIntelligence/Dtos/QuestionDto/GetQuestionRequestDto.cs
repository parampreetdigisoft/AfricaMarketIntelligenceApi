using AfricaMarketIntelligence.Dtos.CommonDto;

namespace AfricaMarketIntelligence.Dtos.QuestionDto
{
    public class GetQuestionRequestDto : PaginationRequest
    {
        public int? PillarID { get; set; }
    }
}
