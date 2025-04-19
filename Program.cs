// This project is intended as a sadaqah jariyah (صدقة جارية)
// Feel free to use, share, and improve it. May it benefit others.


using System;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Extracting the saved Wifi network on the device: ");

        var profiles = WifiHelper.GetProfiles();



        foreach (var profile in profiles)
        {
            Console.WriteLine ("\n--------------------");
            Console.WriteLine ($"Network:   {profile.Name}");
            Console.WriteLine ($"Password:  {profile.Password}");
            Console.WriteLine ("--------------------\n");

        }
        WifiHelper.SaveToCsv(profiles, "wifi_profiles.csv"); 

        Console.WriteLine ("Finished, press Enter to exit...");
        Console.ReadLine();
    }
}
