using AutoMapper;
using EstoqueTechTest.Data.Repositories;
using EstoqueTechTest.Domain.DTOs;
using EstoqueTechTest.Domain.Entities;

namespace EstoqueTechTest.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService( IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ProductDTO> CreateAsync(CreateProductDTO entity)
        {
            try
            {
                var product = _mapper.Map<Product>(entity);
                await _repository.AddAsync(product);

                return _mapper.Map<ProductDTO>(product);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var product = await _repository.GetByIdAsync(id);
                if(product == null) { return false; }

                await _repository.DeleteAsync(id);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<ProductDTO>> GetAllAsync()
        {
            try
            {
                var products = await _repository.GetAllAsync();

                return _mapper.Map<IEnumerable<ProductDTO>>(products);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<ProductDTO> GetByIdAsync(Guid id)
        {
            try
            {
                var product = await _repository.GetByIdAsync(id);

                return _mapper.Map<ProductDTO>(product);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<ProductDTO> UpdateAsync(Guid id, UpdateProductDTO entity)
        {
            try
            {
                var product = await _repository.GetByIdAsync(id);
                if(product == null) { return null; }

                _mapper.Map(entity, product);
                await _repository.UpdateAsync(product);

                return _mapper.Map<ProductDTO>(product);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
