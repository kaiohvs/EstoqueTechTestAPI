using EstoqueTechTest.Domain.DTOs;
using EstoqueTechTest.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueTechTest.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetById(Guid id)
        {
            try
            {
                var product = _service.GetByIdAsync(id);

                if (product == null)
                {
                    return NotFound();
                }

                return Ok(product);
            }
            catch (Exception ex)            {
                
                return StatusCode(500, "Ocorreu um erro ao obter todos os produtos.");
            }
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetAllAsync()
        {
            try
            {
                var products = await _service.GetAllAsync();

                return Ok(products);
            }
            catch (Exception ex)
            {               
                return StatusCode(500, "Ocorreu um erro ao obter todos os produtos.");
            }
        }
        [HttpPost]
        public async Task<ActionResult<ProductDTO>> CreateProduct(CreateProductDTO entity)
        {
            try
            {
                var createdProduct = await _service.CreateAsync(entity);
                return CreatedAtAction(nameof(GetById), new { id = createdProduct.Id }, createdProduct);
            }
            catch (Exception ex)
            {                
                return StatusCode(500, "Ocorreu um erro ao criar o Produco.");
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<ProductDTO>> UpdateProduct(Guid id, UpdateProductDTO entity)
        {
            try
            {
                var updatedProduct = await _service.UpdateAsync(id, entity);
                if (updatedProduct == null)
                {
                    return NotFound();
                }
                return Ok(updatedProduct);
            }
            catch (Exception ex)            {
                
                return StatusCode(500, "Ocorreu um erro ao atualizar o produto.");
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(Guid id)
        {
            try
            {
                var result = await _service.DeleteAsync(id);
                if (!result)
                {
                    return NotFound();
                }
                return NoContent();
            }
            catch (Exception ex)            {
                
                return StatusCode(500, "Ocorreu um erro ao excluir o anime.");
            }
        }
    }
}
