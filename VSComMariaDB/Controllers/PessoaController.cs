using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VSComMariaDB.Model;

namespace VSComMariaDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        /// <summary>
        /// Pegar a lista de todas as pessoas.
        /// </summary>
        /// <returns></returns>
        [HttpGet]

        public List<Pessoa> GetList()
        {
            var _DbContext = new _DbContext();
            var vLista = _DbContext.Pessoa.ToList();

            return vLista;
        }

        /// <summary>
        /// Buscar pessoa por Id
        /// </summary>
        /// <param name="id"> ID da Pessoa</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Pessoa GetPessoa(int id)
        {
            //Instanciar o banco de dados
            var _DbContext = new _DbContext();

            //Selecionar a pessoa pelo ID
            //var vPessoa = _DbContext.Pessoa.Where(x => x.Id == id).FirstOrDefault();
            var vPessoa = _DbContext.Pessoa.Find(id);

            //retornar a solicitação
            return vPessoa;
        }

        [HttpPost("Inserir")]
        public Pessoa Inserir(Pessoa pessoa)
        {
            var _DbContext = new _DbContext();

            _DbContext.Pessoa.Add(pessoa);
            _DbContext.SaveChanges();
            return pessoa;
        }

        [HttpPut("Alterar")]
        public Pessoa Alterar(Pessoa pessoa)
        {

            var _DbContext = new _DbContext();

            _DbContext.Pessoa.Entry(pessoa).State = EntityState.Modified;
            _DbContext.SaveChanges();
            return pessoa;

        }

        [HttpDelete("{id}")]

        public ActionResult Delete(int id)
        {
            var _DbContext = new _DbContext();

            //Localiza a pessoa com ID solicitado em front end
            var vPessoa = _DbContext.Pessoa.Find(id);

            //Remove a pessoa localizada
            _DbContext.Pessoa.Remove(vPessoa);

            _DbContext.SaveChanges();

            return Ok();
        }
    }
}
