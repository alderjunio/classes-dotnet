namespace dotnet.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ExibirQuantidadeDeAlunosMatriculados(){
            int quantidade = Alunos.Count;
            return quantidade;
        }
    }
}