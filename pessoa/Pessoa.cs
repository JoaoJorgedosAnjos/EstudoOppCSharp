public class Pessoa
{
    public Pessoa(string nome, int idade, string email, int anoEscolar)
    {
        VerifyIfNullOrEmpty(nome);
        Email = email;
        Idade = idade;
        VerificarIdade();
        AnoEscolar = anoEscolar;
    }

    public Pessoa(string nome, int idade, string email, string materia)
    {
        VerifyIfNullOrEmpty(nome);
        Email = email;
        Idade = idade;
        Materia = materia;
        VerificarIdade();
    }

    public string Nome { get; set; }
    public int Idade { get; set; }
    public string? Email { get; set; } = string.Empty;
    public string? Materia { get; set; } = string.Empty;
    public int AnoEscolar { get; set; }

    public virtual string GetNome()
    {
        return string.Empty;
    }

    public virtual void VerifyIfNullOrEmpty(string nome)
    {
        if (string.IsNullOrEmpty(nome))
            Console.WriteLine("Nome não pode ser nulo.");
        else
            Nome = nome;
    }

    public virtual void SetIdade(int idade) { }

    public virtual void VerificarIdade() { }

}
