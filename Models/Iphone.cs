namespace DesafioPOO.Models
{
        public class Iphone : Smartphone
        {
            public Iphone(string numero, string modelo, string imei, int memoria) : base( numero, modelo, imei, memoria)
            {
        
            }
            // TODO: Sobrescrever o método "InstalarAplicativo"

            public override void InstalarAplicativo(string nomeApp)
            {
                Console.WriteLine($"Seu App {nomeApp} está sendo baixado na Apple Store!");
            }
        }

}