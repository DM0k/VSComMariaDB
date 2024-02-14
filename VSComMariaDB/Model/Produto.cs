using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VSComMariaDB.Model
{
    public class Produto
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(100)]
        public string? Descricao { get; set; }

        [Precision(10,2)]
        public decimal Preco { get; set; }
        
        public bool Disponivel { get; set; }
        
        public bool Novidade { get; set; }

        [MaxLength(1000)]
        public string? Imagem { get; set;}

    }
}
