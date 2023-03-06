Console.ForegroundColor = ConsoleColor.DarkCyan;

string[] zajmy = {"hry obzvlášť MOBA", "jízda na kole"};

Console.WriteLine("Cs cs jsem Patrik, chodím na SŠ Educhem a mám rád/baví mě: ");
foreach(var item in zajmy)
{
    Console.WriteLine(item);
}