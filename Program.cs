
using dotnet.Models;

Pessoa p1 = new Pessoa("Alder", "Costa");
Pessoa p2 = new Pessoa("Helen", "Moreno");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles Básico";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();





// Pessoa pessoa = new Pessoa();

// pessoa.Nome = "alder";
// pessoa.Sobrenome = "costa";
// pessoa.Idade = 41;
// pessoa.Apresentar();
