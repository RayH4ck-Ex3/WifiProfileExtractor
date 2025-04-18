using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;

public static class WifiHelper   
{
    public static List<WifiProfile> GetProfiles()  
    {
        var profiles = new List<WifiProfile>();    
        var output = RunCommand("netsh wlan show profiles");    

        var matches = Regex.Matches(output, @"All User Profile\s*:\s*(.+)");   

        foreach (Match match in matches)    
        {
            string profileName = match.Groups[1].Value.Trim();  
            string password = GetWifiPassword(profileName);    

            profiles.Add(new WifiProfile    
            {
                Name = profileName,   
                Password = password    
            });
        }

        return profiles;     
    }

    private static string GetWifiPassword(string profileName)    
    {
        var output = RunCommand($"netsh wlan show profile name=\"{profileName}\" key=clear");    
        var match = Regex.Match(output, @"Key Content\s*:\s*(.+)");     
        return match.Success ? match.Groups[1].Value.Trim() : "(Not Stored/Found)";     
    }

    private static string RunCommand(string command)  
    {
        var processInfo = new ProcessStartInfo("cmd.exe", "/c " + command)   
        {
            RedirectStandardOutput = true,  
            UseShellExecute = false, 
            CreateNoWindow = true,   
            StandardOutputEncoding = System.Text.Encoding.UTF8    
        };
        
        using (var process = Process.Start(processInfo))    
        {
            return process.StandardOutput.ReadToEnd();      
        }
    }

    public static void SaveToCsv (List<WifiProfile> profiles, string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine("Network Name, Passowrd");
            
            foreach (var profile in profiles)
            {
                writer.WriteLine($"{profile.Name}, {profile.Password}");
            }
        }
        Console.WriteLine($"Result have been saved to {fileName}");
    }
}