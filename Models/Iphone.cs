namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        private List<string> Instalados = new List<string>(); //Installed apps list, not in abstract because IRL the storage formats are radically different
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarApp(string nomeApp) //Install apps
        {
            Instalados.Add(nomeApp);
            Console.WriteLine($"Instalando {nomeApp} no seu Apple {Modelo}..."); //Installing APP on your Apple DEVICE
        }

        public override void DesinstalarApp(string nomeApp) //Remove apps
        {
            if (Instalados.Contains(nomeApp))
            {
                Instalados.Remove(nomeApp);
                Console.WriteLine($"Removendo {nomeApp} no seu Apple {Modelo}..."); //Removing APP from your Apple DEVICE
            }else
            {
                Console.WriteLine("Aplicação não encontrada!"); //App not found
            }
        }

        public override void ListarApps() //List Apps
        {
            foreach (var app in Instalados)
            {
                Console.WriteLine(app);
            }
        }
        
    }
}