using AfricaMarketIntelligence.Common.Models;
using AfricaMarketIntelligence.Dtos.dashboard;
using AfricaMarketIntelligence.Models;

namespace AfricaMarketIntelligence.IServices
{
    public interface ISignalDashboardService
    {
        Task<ResultResponseDto<DashboardModeResponseDto>> GetPeaceStressTestDashboard(int countryID, int userId, UserRole userRole, int year);
        Task<ResultResponseDto<DashboardModeResponseDto>> GetEarlyWarningDashboard(int countryID, int userId, UserRole userRole, int year);
        Task<ResultResponseDto<DashboardModeResponseDto>> GetResilienceScorecard(int countryID, int userId, UserRole userRole, int year);
    }
}
