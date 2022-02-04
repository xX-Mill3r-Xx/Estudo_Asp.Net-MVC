using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanche")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O nome do lanche deve ser informado!")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2} caracteres")]
        [Display(Name = "Nome do lanche")]
        public string LancheNome { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada!")]
        [Display(Name = "Descrição")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no minimo {1} Caracteres!")]
        [MaxLength(200, ErrorMessage = "Descrição não pode exceder {1} Caracteres!")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada!")]
        [Display(Name = "Descrição Detalhada")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no minimo {1} Caracteres!")]
        [MaxLength(2000, ErrorMessage = "Descrição não pode exceder {1} Caracteres!")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Valor deve ser informado!")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99, ErrorMessage ="O preço deve estar entre R$1.00 e R$99.99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200,ErrorMessage ="O {0} deve ter no maximo {1} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Thumb")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Em destaque?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
