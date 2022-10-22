/* 22/10/2022 */

namespace ConsoleApp4
{
    internal class Program {
        static void Main(string[], args)
        {
            Cliente cliente = new Cliente();   // Crio um novo cliente
            cliente.Endereco = new Endereco("rua a", "Bessa", "1", "S//em complemento");

            cliente.EnderecoLista = new List<Endereco>();

            cliente.EnderecoLista.Add(cliente.Endereco);
            cliente.EnderecoLista.Add(new Endereco("rua b", "Cabo Branco", "2", "Tororó"));

            cliente.Endereco.Numero = "22";
        
            foreach (var item in cliente.EnderecoLista)
            {
                item.Numero = "33";    // Estrutura de repetição do próprio C#
            }

            cliente.EnderecoLista.ForEach(
        
                item => item.Numero = "33"    // Estrutura de repetição de EnderecoLista (ou qualquer Lista)

                );
                    
            var endereco33 = cliente.EnderecoLista.Select(x => x.Numero.Equals("33"));
        }
    }
}