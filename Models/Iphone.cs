namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
        public class Iphone : Smartphone
    {
        private string memoria;

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

       


        // TODO: Sobrescrever o método "InstalarAplicativo"


        public override void InstalarAplicativo(string nomeApp)
        {
            string texto = $"instalando o aplicativo {nomeApp} no iphone";
            Console.WriteLine(texto);
        }
    }
}