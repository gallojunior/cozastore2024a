using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cozastore.Models;

[Table("Produto")]
public class Produto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(100, ErrorMessage = "O Nome deve possuir no máximo 100 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Descrição Resumida")]
    [StringLength(1000, ErrorMessage = "A Descrição Resumida deve possuir no máximo 1000 caracteres")]
    public string DescricaoResumida { get; set; }

    [Display(Name = "Descrição Completa")]
    [StringLength(8000, ErrorMessage = "A Descrição Completa deve possuir no máximo 8000 caracteres")]
    public string DescricaoCompleta { get; set; }

    [StringLength(10, ErrorMessage = "O SKU deve possuir no máximo 10 caracteres")]
    public string SKU { get; set; }

    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(10,2)")]  // 99.999.999,99
    [Required(ErrorMessage = "Por favor, informe o Preço de Venda")]
    public decimal Preco { get; set; }
    
    [Display(Name = "Preço com Desconto")]
    [Column(TypeName = "decimal(10,2)")]  // 99.999.999,99
    public decimal PrecoDesconto { get; set; }

    [Display(Name = "Produto em Destaque?")]
    public bool Destaque { get; set; }

    [Column(TypeName = "decimal(8,3)")]  // 99.999,999
    public decimal Peso { get; set; }

    [StringLength(30, ErrorMessage = "O Material deve possuir no máximo 30 caracteres")]
    public string Material { get; set; }
    
    [Display(Name = "Dimensão")]
    [StringLength(30, ErrorMessage = "A Dimensão deve possuir no máximo 30 caracteres")]
    public string Dimensao { get; set; }

    [Display(Name = "Categoria")]
    [Required(ErrorMessage = "Por favor, informe a Categoria")]
    public int CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]
    public Categoria Categoria { get; set; }

    public ICollection<Estoque> Estoque { get; set; }
    public ICollection<ProdutoFoto> Fotos { get; set; }
}

