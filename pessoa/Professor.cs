public class Professor : Pessoa
{
    public Professor(string nome, int idade, string email, string materia)
        : base(nome, idade, email, materia) { }

    public override string GetNome()
    {
        if (string.IsNullOrEmpty(Nome))
            return "Nome não pode ser nulo.";
        return $"O nome do professor é {Nome} e tem {Idade} anos.";
    }

    public override void VerificarIdade()
    {
        if (Idade > 18)
            Console.WriteLine($"{Nome} pode ser professor.");
        else
            Console.WriteLine($"{Nome} não pode ser professor.");
    }
}
