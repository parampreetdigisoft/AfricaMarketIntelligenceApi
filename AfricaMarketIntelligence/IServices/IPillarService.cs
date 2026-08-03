using AfricaMarketIntelligence.Common.Models;
using AfricaMarketIntelligence.Dtos.AssessmentDto;
using AfricaMarketIntelligence.Dtos.CommonDto;
using AfricaMarketIntelligence.Dtos.PillarDto;
using AfricaMarketIntelligence.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AfricaMarketIntelligence.IServices
{
    public interface IPillarService
    {
        Task<List<GetPillarDto>> GetAllAsync(int userId, UserRole userRole);
        Task<Pillar> GetByIdAsync(int id);
        Task<Pillar> AddAsync(Pillar pillar);
        Task<ResultResponseDto<Pillar>> AddPillarAsync(AddPillarDto pillar);
        Task<Pillar> UpdateAsync(int id, UpdatePillarDto pillar);
        Task<ResultResponseDto<List<PillarKpiMappingDto>>> GetPillarKpiMappingsAsync(int pillarId);
        Task<ResultResponseDto<bool>> DeleteAsync(int id);
        Task<Tuple<string, byte[]>> ExportPillarsHistoryByUserId(GetCountryPillarHistoryRequestDto requestDto);
        Task<PaginationResponse<PillarsHistroyResponseDto>> GetResponsesByUserId(GetPillarResponseHistoryRequestNewDto request, UserRole userRole);

    }
} 