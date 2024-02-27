using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cozastore.Models;

[Table("Cor")]
public class Cor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Código Hexa", Prompt = "Ex. #FEFEFE")]
    [Required(ErrorMessage = "Por favor, informe o Código Hexa")]
    [StringLength(7, ErrorMessage = "O Código Hexa deve possuir no máximo 7 caracteres")]
    public string CodigoHexa { get; set; }

    public ICollection<Estoque> Estoque { get; set; }

}
