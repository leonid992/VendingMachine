using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace VendingMachine
{
    public class LoadMenuJson : ILoadMenu
    {
        public List<Coffee> LoadMenu()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            if (projectDirectory.Contains("Tests"))
            {
                projectDirectory = projectDirectory.Replace("UnitTests", "");
            }
            string json = File.ReadAllText($"{projectDirectory}\\menu.json");
            return JsonSerializer.Deserialize<List<Coffee>>(json);
        }
    }
}
