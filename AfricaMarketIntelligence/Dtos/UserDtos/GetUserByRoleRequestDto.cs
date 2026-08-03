using AfricaMarketIntelligence.Dtos.CommonDto;
using AfricaMarketIntelligence.Models;

namespace AfricaMarketIntelligence.Dtos.UserDtos
{
    public class GetUserByRoleRequestDto : PaginationRequest
    {
        public UserRole? GetUserRole { get; set; }
        public int UserID { get; set; }
    }
}
