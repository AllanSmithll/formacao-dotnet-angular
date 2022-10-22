/* 08/10/2022 */
/* Faz parte do exercício 1 */

public class Candidato
{
    public string Nome { get; }
    public string Numero { get; }
    public int Voto { get; set;}

    public Candidato(string nome, string numero)
    {
        Nome = nome;
        Numero = numero;
    }
}