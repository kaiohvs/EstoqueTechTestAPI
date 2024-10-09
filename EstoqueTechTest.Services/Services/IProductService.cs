
using EstoqueTechTest.Domain.DTOs;

namespace EstoqueTechTest.Services.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllAsync();
        Task<ProductDTO> GetByIdAsync(Guid id);
        Task<ProductDTO> CreateAsync(CreateProductDTO entity);
        Task<ProductDTO> UpdateAsync(Guid id, UpdateProductDTO entity);
        Task<bool> DeleteAsync(Guid id);
    }
}
