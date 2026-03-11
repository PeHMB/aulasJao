namespace ApiFinanceiro.Models
{
    public class Conta
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public required string Descricao { get; set; }

        public required string Categoria { get; set; }

        public required decimal Valor { get; set; }

        public required DateOnly DataPrevisao { get; set; }
        public required DateOnly DataRecebimento { get; set; }

        public required Boolean Situacao { get; set; }
        public required string Observacao {  get; set; }

    }
}
