namespace DesafioPOO.Models
{
    // TODO: Tarefa Realizada
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base( numero,  modelo,  imei,  memoria){}

        // TODO: Tarefa Realizada
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"instalando aplicativo {nomeApp} no Nokia");
        }
    }
}