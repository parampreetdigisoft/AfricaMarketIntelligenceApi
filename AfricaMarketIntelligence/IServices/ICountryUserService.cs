using AfricaMarketIntelligence.Common.Models;
using AfricaMarketIntelligence.Dtos.AiDto;
using AfricaMarketIntelligence.Dtos.AssessmentDto;
using AfricaMarketIntelligence.Dtos.CountryDto;
using AfricaMarketIntelligence.Dtos.CommonDto;
using AfricaMarketIntelligence.Dtos.kpiDto;
using AfricaMarketIntelligence.Dtos.PublicDto;
using AfricaMarketIntelligence.Enums;
using AfricaMarketIntelligence.Models;
using AfricaMarketIntelligence.Dtos.CountryUserDto;

namespace AfricaMarketIntelligence.IServices
{
    public interface ICountryUserService
    {
        Task<List<Pillar>> GetAllAsync(int userId, UserRole userRole);
        Task<ResultResponseDto<List<PartnerCountryResponseDto>>> GetCountryUserCountries(int userID);
        Task<ResultResponseDto<CountryHistoryDto>> GetCountryHistory(int userId, TieredAccessPlan tier);
        Task<ResultResponseDto<List<GetCountriesSubmitionHistoryResponseDto>>> GetCountriesProgressByUserId(int userID);
        Task<GetCountryQuestionHistoryResponseDto> GetCountryQuestionHistory(UserCountryRequestDto userCountryRequstDto);
        Task<PaginationResponse<CountryResponseDto>> GetCountriesAsync(PaginationRequest request);
        Task<ResultResponseDto<CountryDetailsDto>> GetCountryDetails(UserCountryRequestDto userCountryRequstDto);
        Task<ResultResponseDto<List<CountryPillarQuestionDetailsDto>>> GetCountryPillarDetails(UserCountryGetPillarInfoRequestDto userCountryGetPillarInfoRequestDto);
        Task<ResultResponseDto<string>> AddCountryUserKpisCountryAndPillar(AddCountryUserKpisCountryAndPillar payload,int userID, string tierName);
        Task<ResultResponseDto<List<GetAllKpisResponseDto>>> GetCountryUserKpi(int userID, string tierName);
        Task<ResultResponseDto<CompareCountryResponseDto>> CompareCountries(CompareCountryRequestDto c, int userId, string tierName, bool applyPagination = true);
        Task<ResultResponseDto<AiCountryPillarResponseDto>> GetAICountryPillars(AiCountryPillarRequestDto r, int userID, string tierName);
        Task<Tuple<string, byte[]>> ExportCompareCountries(CompareCountryRequestDto request, int userId, string tierName);
    }
}
