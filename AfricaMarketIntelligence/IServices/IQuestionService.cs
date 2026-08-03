using AfricaMarketIntelligence.Common.Models;
using AfricaMarketIntelligence.Dtos.AssessmentDto;
using AfricaMarketIntelligence.Dtos.CommonDto;
using AfricaMarketIntelligence.Dtos.PillarDto;
using AfricaMarketIntelligence.Dtos.QuestionDto;
using AfricaMarketIntelligence.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AfricaMarketIntelligence.IServices
{
    public interface IQuestionService
    {
        Task<List<GetPillarDto>> GetPillarsAsync();
        Task<PaginationResponse<GetQuestionResponse>> GetQuestionsAsync(GetQuestionRequestDto requestDto);
        Task<Question> AddQuestionAsync(Question q);
        Task<ResultResponseDto<string>> AddUpdateQuestion(AddUpdateQuestionDto q);
        Task<ResultResponseDto<string>> AddBulkQuestion(AddBulkQuestionsDto q);
        Task<Question> EditQuestionAsync(int id, Question q);
        Task<bool> DeleteQuestionAsync(int id);
        Task<ResultResponseDto<GetPillarQuestionByCountryResponse>> GetQuestionsByCountryIdAsync(CountryPillerRequestDto request, int userId);
        Task<Tuple<string,byte[]>> ExportAssessment(int userCountryMappingID, int userId, UserRole role);
        Task<ResultResponseDto<List<QuestionsByUserPillarsResponsetDto>>> GetQuestionsHistoryByPillar(GetCountryPillarHistoryRequestDto requestDto, UserRole role);
        Task<ResultResponseDto<GetPillarQuestionByCountryResponse>> GetQuestionsByCountryMappingIdForAnalyst(CountryPillerRequestDto request, int userId);
    }
} 