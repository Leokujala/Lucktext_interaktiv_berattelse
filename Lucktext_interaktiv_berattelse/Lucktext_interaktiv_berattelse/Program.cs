Console.WriteLine("Det var en gång en robot som hette LEO05. LEO05:s värsta fiende var roboten OEL50 som retades hela tiden.");
Console.WriteLine("Ska roboten LEO05 ska vara skygg eller modig?");
Console.WriteLine("Svara i små bokstäver!!");


string ksla = Console.ReadLine();
if (ksla == "skygg")
{
    Console.WriteLine("Roboten LEO05 var väldigt skygg och vågade aldrig stå upp för sig själv när OEL50 var taskig mot honom.");
    Console.WriteLine("LEO05 förblev mobbad och stod aldrig upp för sig själv");
}
if (ksla == "modig")
{
    Console.WriteLine("Roboten LEO05 var en modig en och han stog alltid upp för sig själv när OEL50 var taskig mot honom.");
    Console.WriteLine("Ska LEO05 ska klappa till OEL05 nästa gång han retas?");

}
string val = Console.ReadLine();
if (val == "ja")
{
    Console.WriteLine("LEO05 stod tillslut upp för sig själv och slog till OEL50 när han retades. OEL50 gjorde aldrig om det.");
}

if (val == "nej")
{
    Console.WriteLine("Nästa gång LEO05 blev retad så gjorde han inget och OEL50 retas än idag!");
}






Console.ReadLine();
