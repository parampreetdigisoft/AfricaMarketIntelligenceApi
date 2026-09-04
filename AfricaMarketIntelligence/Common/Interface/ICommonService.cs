using AfricaMarketIntelligence.Common.Models;
using AfricaMarketIntelligence.Common.Models.views;
using AfricaMarketIntelligence.Dtos.AssessmentDto;
using AfricaMarketIntelligence.Dtos.CountryDto;
using AfricaMarketIntelligence.Dtos.PillarDto;
using AfricaMarketIntelligence.Models;

namespace AfricaMarketIntelligence.Common.Interface
{
    public interface ICommonService
    {
        Task<List<EvaluationCountryProgressResultDto>> GetCountriesProgressAsync(int userId,int role, int year, int countryID = 0);
        Task<List<EvaluationCountryProgressHistoryResultDto>> GetCountriesProgressHistoryAsync(int userId, int role, int fromYear, int toYear);
        Task<List<GetCountriesProgressAdminDto>> GetCountriesProgressForAdmin(int userId, int role, int year);
        Task<List<CountryRankingResultDto>> GetCountriesRankings(int countryId, int year);
        Task<List<GetPillarDto>> GetPillars();
        void ClearPillarCache();
        Task<List<GetAssessmentResponseDto>> GetUserDetailsAssignedToCountry(int year, int countryID = 0);

        Task<List<GetDashboardModeResult>> GetDashboardModeResults(int userId, int role, int dashboardModeID, int countryID = 0);
        Task<ResultResponseDto<bool>> RevokeCountriesPermission(List<int> countryIds, int userID, int year);
    }
}
