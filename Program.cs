using dotnet.Models;
using System.Globalization;


CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 25489.63M;

Console.WriteLine(valorMonetario.ToString("C2"));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));


//======================================================================

// int numero1 = 10;
// int numero2 = 20;

// int resultado = numero1 + numero2;

// Console.WriteLine($"A soma de {numero1} + {numero2} é igual a {resultado}");



// ========================================================================


// Pessoa p1 = new Pessoa("Alder", "Costa");
// Pessoa p2 = new Pessoa("Helen", "Moreno");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles Básico";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();


// ==========================================================================




// Pessoa pessoa = new Pessoa();

// pessoa.Nome = "alder";
// pessoa.Sobrenome = "costa";
// pessoa.Idade = 41;
// pessoa.Apresentar();
