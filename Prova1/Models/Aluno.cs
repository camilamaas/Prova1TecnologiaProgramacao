//Camila Maas
namespace Prova1.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        public Faixa Faixa { get; set; }

        public TipoDeAssociacao TipoDeAssociacao { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }
    }
}