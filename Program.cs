﻿






class App
{




    static void Main(string[] args)
    {

        Console.WriteLine("Bitte geben sie ihren Namen ein");

        string name = Console.ReadLine();


        Console.WriteLine("Wilkommen " + name + " es freut mich sie kennenzulernen");
        Console.WriteLine("");
        Console.WriteLine(@"Dieshier ist ein Lexikon zum Thema Discofalafel. Wenn sie alle stichwörter sehen wollen geben sie  discofalafel  ein, 
         dann erhalten sie eine grobe Liste. Oder sie Probieren Selber ihr glück ;D");


        string Stichwort = Console.ReadLine();

        if (Stichwort == ("discofalafel"))
        {
            Console.WriteLine("Liste:");
            Console.WriteLine("erfolge , projekte , ziele ");

        }
        else if (Stichwort == ("erfolge"))
        {
            Console.WriteLine("Ich habe bisher ein eigenen Minecraft Server eröffnet: https://discord.gg/358N527Baq");
            Console.WriteLine("außerdem bin ich auf vielen Servern Mod und admin");

        }
        else if (Stichwort == ("projekte"))
        {
            Console.WriteLine("Ich arbeite aktiv an meinem Minecraft Server: https://discord.gg/358N527Baq");
            Console.WriteLine("außerdem Lerne ich Programmieren wie man sieht");

        }
        else if (Stichwort == ("ziele"))
        {
            Console.WriteLine("Ich möchte das mein Minecraft Server erfolg hat: https://discord.gg/358N527Baq");
            Console.WriteLine("außerdem will ich programmieren Lernen und viel Sport treiben");

        }
        else
        {
            Console.WriteLine("keine ergebnisse Gefunden");
        }

        Console.WriteLine("");

        Console.WriteLine("drücke eine Beliebige Taste um das Programm zu beenden");
        Console.ReadLine();
    }
}
