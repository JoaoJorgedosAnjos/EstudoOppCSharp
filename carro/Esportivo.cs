public class Esportivo : Carro
{
    public Esportivo(string marca, string modelo, string cor, bool eEletrico) : base(marca, modelo, cor, eEletrico)
    {

    }
    public override string GetCarInfos()
    {
        string eEletrico = "";
        if (EEletrico)
        {
            eEletrico = "é";
        }
        else
        {
            eEletrico = "não é";
        }
        return $"A marca do carro é {Marca}, o modelo é {Modelo}, com a cor {Cor}. O modelo {eEletrico} eletrico.";
    }
}
