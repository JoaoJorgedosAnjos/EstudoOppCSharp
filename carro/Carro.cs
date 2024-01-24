public class Carro
{
    public Carro(string marca, string modelo, string cor, bool eEletrico )
    {
        Marca = marca;
        Modelo = modelo;
        Cor = cor;
        EEletrico = eEletrico;
    }
     public Carro(string marca, string modelo, string cor, int numeroDePortas)
    {
        Marca = marca;
        Modelo = modelo;
        Cor = cor;
        NumeroDePortas = numeroDePortas;
    }

    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Cor { get; set; }
    public int NumeroDePassageiros { get; set; }
    public int NumeroDePortas { get; set; }
    public int AnoDeLancamento { get; set; }
    public bool EEletrico { get; set; }

    public virtual string GetCarInfos(){
        return string.Empty;
    }

}
