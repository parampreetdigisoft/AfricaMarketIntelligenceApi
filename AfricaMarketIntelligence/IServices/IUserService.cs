using AfricaMarketIntelligence.Common.Models;
using AfricaMarketIntelligence.Dtos.AssessmentDto;
using AfricaMarketIntelligence.Dtos.CommonDto;
using AfricaMarketIntelligence.Dtos.UserDtos;
using AfricaMarketIntelligence.Models;

namespace AfricaMarketIntelligence.IServices
{
    public interface IUserService
    {
        User GetByEmail(string email);
        Task<PaginationResponse<GetUserByRoleResponse>> GetUserByRoleWithAssignedCountry(GetUserByRoleRequestDto requestDto, int userid, UserRole userRole);
        Task<ResultResponseDto<List<PublicUserResponse>>> GetEvaluatorByAnalyst(GetAssignUserDto requestDto);
        Task<ResultResponseDto<List<GetAssessmentResponseDto>>> GetUsersAssignedToCountry(int countryId);
        Task<ResultResponseDto<UpdateUserResponseDto>> GetUserInfo(int userId);

    }
} 