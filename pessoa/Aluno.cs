public class Aluno : Pessoa
{
    public Aluno(string nome, int idade, string email, int anoEscolar)
        : base(nome, idade, email, anoEscolar) { }

    public override string GetNome()
    {
        if (string.IsNullOrEmpty(Nome))
            return "Nome não pode ser nulo.";
        return $"O nome do aluno é {Nome} e tem {Idade} anos.";
    }

    public override void VerificarIdade()
    {
        if (Idade < 18)
            Console.WriteLine($"{Nome} pode ser aluno.");
        else
            Console.WriteLine($"{Nome} não pode ser aluno.");
    }

}
