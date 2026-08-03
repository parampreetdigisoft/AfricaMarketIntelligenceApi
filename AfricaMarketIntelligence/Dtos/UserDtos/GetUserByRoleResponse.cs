using AfricaMarketIntelligence.Dtos.CountryDto;

namespace AfricaMarketIntelligence.Dtos.UserDtos
{
    public class GetUserByRoleResponse : PublicUserResponse
    {
        public List<AddUpdateCountryDto> Countries { get; set; } = new();
    }
}
