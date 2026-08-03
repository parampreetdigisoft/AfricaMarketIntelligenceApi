using AfricaMarketIntelligence.Dtos.CommonDto;
using AfricaMarketIntelligence.Models;

namespace AfricaMarketIntelligence.Dtos.kpiDto
{
    public class GetAnalyticalLayerRequestDto : PaginationRequest
    {
        public int? CountryID { get; set; }
        public int? LayerID { get; set; }
        public int Year { get; set; } = DateTime.Now.Year;
    }
}
