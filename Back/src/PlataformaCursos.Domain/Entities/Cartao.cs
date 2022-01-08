namespace PlataformaCursos.Domain.Entities
{
    public class Cartao
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int Codigo { get; set; }
        public string NomeTitular { get; set; }
        public string DataVencimento { get; set; }

        public Conta Conta { get; set; }
    }
}