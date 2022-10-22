/* 22/10/2022 */
// Aula 2 de .NET com C#, do dia 22/10/2022

namespace ConsoleApp4
{

    public class Pessoa : TipoPessoa, IPessoa
    {
        public Guid Id { get; set; }
        protected string Nome { get; set; }
        protected string CPF { get; set; }
        protected string Email { get; set; }
        public List<Endereco> EnderecoLista { get; set; }
        public Endereco Endereco  { get; set; }

        public Pessoa()
        {
            Id = Guid.NewGuid();
        }

        public Endereco GetEndereco()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar()
        {
            throw new NotImplementedException();
        }

        public void Editar()
        {

        }
    }
}