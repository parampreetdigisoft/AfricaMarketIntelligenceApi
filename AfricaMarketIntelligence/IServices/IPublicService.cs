using AfricaMarketIntelligence.Common.Models;
using AfricaMarketIntelligence.Dtos.chatDto;
using AfricaMarketIntelligence.Dtos.CommonDto;
using AfricaMarketIntelligence.Dtos.PublicDto;

namespace AfricaMarketIntelligence.IServices
{
    public interface IPublicService
    {
        Task<ResultResponseDto<List<PartnerCountryResponseDto>>> getAllCountries();
        Task<ResultResponseDto<List<PillarResponseDto>>> GetAllPillarAsync();
        Task<CountryCityResponse> GetCountriesAndCountries_WithStaleSupport();
        Task<ResultResponseDto<List<PromotedPillarsResponseDto>>> GetPromotedCountries();
        Task<ResultResponseDto<EmergingTrendsResult>> GetEmergingTrendsAndIssues();
        Task<bool> RefreshEmergingTrendsCacheAsync(int countryCount, CancellationToken cancellationToken = default);
        Task<ResultResponseDto<PillarLiveSignalsResult>> GetPillarLiveSignals();
        Task<ResultResponseDto<OverallAfricaMarketResponse>> GetOverAllAfricaMarketScore();

    }
}
