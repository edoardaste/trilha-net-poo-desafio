namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
     public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        

        public override void InstalarAplicativo(string nomeApp)
        {
            string texto = $"instalando o aplicativo {nomeApp} no nokia";
            Console.WriteLine(texto);
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}