namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {
        }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Instalando o aplicativo \"{appName}\" no Iphone!");
        }
    }
}