using AfricaMarketIntelligence.Common.Models;
using AfricaMarketIntelligence.Dtos.CommonDto;
using AfricaMarketIntelligence.Dtos.CountryUserDto;
using AfricaMarketIntelligence.Dtos.kpiDto;
using AfricaMarketIntelligence.Enums;
using AfricaMarketIntelligence.Models;

namespace AfricaMarketIntelligence.IServices
{
    public interface IKpiService
    {
        Task<PaginationResponse<GetAnalyticalLayerResultDto>> GetAnalyticalLayerResults(GetAnalyticalLayerRequestDto request, int userId, UserRole role, TieredAccessPlan userPlan = TieredAccessPlan.Pending);
        Task<ResultResponseDto<List<AnalyticalLayer>>> GetAllKpi(int userId, UserRole role);
        Task<ResultResponseDto<List<AnalyticalLayerPillarMappingDTO>>> GetKPIDetailsByLayerID(int layerID);
        Task<ResultResponseDto<CompareCountryResponseDto>> CompareCountries(CompareCountryRequestDto c, int userId, UserRole role, bool applyPagination = true);

        Task<Tuple<string, byte[]>> ExportCompareCountries(CompareCountryRequestDto request, int userId, UserRole role);
        Task<ResultResponseDto<GetMutiplekpiLayerResultsDto>> GetMutiplekpiLayerResults(GetMutiplekpiLayerRequestDto request, int userId, UserRole role, TieredAccessPlan userPlan = TieredAccessPlan.Pending);
        Task<ResultResponseDto<SummarizeKpiResponseDto>> SummarizeKpiPerformance(SummarizeKpiRequestDto request, int userId, UserRole role);
    }
}
