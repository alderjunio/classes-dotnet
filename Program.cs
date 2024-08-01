using dotnet.Models;
using System.Globalization;
using Newtonsoft.Json;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Marreta", 25.00M);
Venda v2 = new Venda(2, "Serrote", 45.00M);
Venda v3 = new Venda(3, "Esquadro", 27.99M);

listaVendas.Add(v1);
listaVendas.Add(v2);
listaVendas.Add(v3);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);















//=================================================================================================================



// string[] linhasExemplo = File.ReadAllLines("Arquivos/arquivoLeitura1.txt");
// Console.WriteLine("Chegou até aqui");

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro nao leitura do arquivo. O Arquivo não foi encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro nao leitura do arquivo. O caminho da pasta não foi encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
// Console.WriteLine("Chegou até aqui");
// }





//====================================================================


// string dataString = "2022-04-170 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, 
//                 "yyyy-MM-dd HH:mm", 
//                 CultureInfo.InvariantCulture, 
//                 DateTimeStyles.None, 
//                 out DateTime data);
// if(sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else 
// {
//     Console.WriteLine($"{dataString} não é uma data válida");  
// }





// Console.WriteLine(data);
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
// Console.WriteLine(data.ToString("dd/MM/yyyy"));
// Console.WriteLine(data.ToString("dd-MM-yyyy"));
// Console.WriteLine(data.ToString("dd/M/yyyy"));
// Console.WriteLine(data.ToString("dd/M/yyyy"));
// Console.WriteLine(data.ToString("HH:mm"));
// Console.WriteLine(data.ToString("hh:mm"));



//======================================================================


// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 25489.63M;

// Console.WriteLine(valorMonetario.ToString("C2"));

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));


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
