/* 08/10/2022 */
/* Exercício feito no fim da aula de dotnet */

using System;
using System.Collections.Generic;  /* === Importando bibliotecas do C# === */

Console.Clear();
string? voto;
int nulos = 0;
List<Candidato> candidatos = new List<Candidato>();
candidatos.Add(new Candidato("Allan", "45"));
candidatos.Add(new Candidato("João", "40"));

for (int i = 0; i < 10; i++);
{
    Console.WriteLine($"Vote {candidatos[0].Numero} pra {candidatos[0].Nome} e {candidatos[1].Numero} pra {candidatos[1].Nome}\n");
    voto = Console.ReadLine();
    if (voto == candidatos[0].Numero) candidatos[0].Voto = candidatos[0].Voto + 1;
    else if(voto == candidatos[1].Numero) candidatos[1].Voto = candidatos[1].Voto + 1;
    else nulos++;
}

foreach (Candidato i in candidatos)
{
    Console.WriteLine($"{i.Voto} votos para {i.Nome}\n");
}
Console.Write($"{nulos} votos nulos\n");

if (candidatos[0].Voto > candidatos[1].Voto) Console.WriteLine($"{candidatos[0].Nome} ganhou.");
else if (candidatos[0].Voto == candidatos[1].Voto) Console.WriteLine("Segundo Turno!");
else Console.WriteLine($"{candidatos[1].Nome} ganhou.");

Console.ReadLine();
