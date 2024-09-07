using System.ComponentModel.DataAnnotations;

namespace Minimal_API.Models
{
    public class Produto
    {
        [Key]
        public int? id { get; set; }
        public string? Nome { get; set; }
        public long? Codigo { get; set; }
        public double Preco { get; set; }
        public string? Descricao { get; set; }
        public int QuatidadeEmEstoque { get; set; }
        public double Avaliacao { get; set; }
        public string? Categoria { get; set; }
    }
}
