namespace RestAPIModeloDDD.Domain.Entities
{
    public class Produto : Base
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IsAtivo { get; set; }
    }
}