﻿using System.IO;
using Microsoft.Extensions.Configuration;

namespace UltraliasApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().AddJsonFile("config.json").Build();
            var fileContent = config["FileContent"];

            var tempFolder = Path.GetTempPath();
            var filePath = Path.Combine(tempFolder, "ultraliasfile.txt");
            File.WriteAllText(filePath, fileContent);
        }
    }
}