using DesafioPOO.Models;

Iphone i15 = new Iphone( "81995563493", "Iphone 15", "12949912", 4);
Nokia c12 = new Nokia("8196796784", "C12", "129140212", 3);

Console.WriteLine("-----------TESTE IPHONE-----------"); //TESTING IPHONE
i15.ReceberLigacao();
Console.WriteLine("");
i15.Ligar();
Console.WriteLine("");
i15.InstalarApp("Whatsapp");
Console.WriteLine("");
i15.InstalarApp("Angry Birds");
Console.WriteLine("");
i15.InstalarApp("Google");
Console.WriteLine("");
i15.ListarApps();
Console.WriteLine("--------------------");
i15.DesinstalarApp("Spotify");
Console.WriteLine("--------------------");
i15.DesinstalarApp("Whatsapp");
Console.WriteLine("--------------------");
i15.ListarApps();

Console.WriteLine("-----------TESTE NOKIA-----------"); //TESTING NOKIA
c12.ReceberLigacao();
Console.WriteLine("");
c12.Ligar();
Console.WriteLine("");
c12.InstalarApp("Instagram");
Console.WriteLine("");
c12.InstalarApp("Clash of Clans");
Console.WriteLine("");
c12.InstalarApp("Spotify");
Console.WriteLine("");
c12.ListarApps();
Console.WriteLine("--------------------");
c12.DesinstalarApp("Whatsapp");
Console.WriteLine("--------------------");
c12.DesinstalarApp("Spotify");
Console.WriteLine("--------------------");
c12.ListarApps();