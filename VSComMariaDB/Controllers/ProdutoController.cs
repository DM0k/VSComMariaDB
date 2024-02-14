using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VSComMariaDB.Model;

namespace VSComMariaDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<Produto> GetProdutoByIdAsync(int id)
        {
            var _DbContext = new _DbContext();

            var vProduto = await _DbContext.Produto.FindAsync(id);
            return vProduto;
        }

        [HttpGet("GetProdListAsync")]
        public async Task<List<Produto>> GetProdList()
        {

            var _DbContext = new _DbContext();

            var vProdList = await _DbContext.Produto.ToListAsync();
            return vProdList;
        }

        [HttpPost("InsertProdAsync")]
        public async Task<List<Produto>> InsertProd(List<Produto> Prod)
        {
            var _DbContext = new _DbContext();

            await _DbContext.AddRangeAsync(Prod);
            await _DbContext.SaveChangesAsync();
            return Prod;
        }

        [HttpPut("UpDateProdAsync")]

        public async Task<Produto> AlterarProd(Produto Prod)
        {
            var _DbContext = new _DbContext();

            _DbContext.Produto.Entry(Prod).State = EntityState.Modified;
            await _DbContext.SaveChangesAsync();

            return Prod;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProd(int id)
        {
            var _DbContext = new _DbContext();

            var Prod = await _DbContext.Produto.FindAsync(id);
            _DbContext.Produto.Remove(Prod);
            await _DbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
