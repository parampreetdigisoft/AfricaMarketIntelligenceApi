using AfricaMarketIntelligence.Dtos.CommonDto;

namespace AfricaMarketIntelligence.Dtos.CountryDto
{
    public class CountryPaginationRequest: PaginationRequest
    {
        public int? CountryID { get; set; }
    }
}
