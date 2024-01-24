public class Popular : Carro
{
    public Popular(string marca, string modelo, string cor, int numeroDePortas) : base(marca, modelo, cor, numeroDePortas)
    {
    }

    public override string GetCarInfos()
    {
        return $"A marca do carro é {Marca}, o modelo é {Modelo}, com a cor {Cor} e tem {NumeroDePortas} portas.";
    }

}
