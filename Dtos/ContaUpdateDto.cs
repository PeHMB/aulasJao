using System.ComponentModel.DataAnnotations;

namespace ApiFinanceiro.Dtos
{
    public class ContaUpdateDto : ContaDto
    {
        [Required]
        public required Boolean Situacao { get; set; }

        [Required]
        public DateOnly DataRecebimento { get; set; }
    }
}
