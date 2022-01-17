using AbbreviationGuesser.Models;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AbbreviationGuesser
{
    public class SettingsControl : NotifyEventModel
    {
        private SettingsModel model;
        public static string SettingsPath = Path.Combine(AppContext.BaseDirectory, @"ConfigurationSettings.json");

        public SettingsControl()
        {
            LoadSettings();
        }

        public SettingsModel Model
        {
            get => model;
            set
            {
                model = value;
                OnPropertyChanged();
            }
        }

        public void LoadSettings()
        {
            if(!File.Exists(SettingsPath))
            {
                MessageBox.Show($"Wasn't able to find ConfigurationSettings.json", "Settings file not found", MessageBoxButton.OK, MessageBoxImage.Error);
                OpenFileDialog openFileDialog = new();
                if(openFileDialog.ShowDialog() == true)
                {
                    SettingsPath = openFileDialog.FileName;
                }
            }
            LoadSettingsFile(SettingsPath);
        }

        public void LoadSettingsFile(string filePath)
        {
            Model = JsonConvert.DeserializeObject<SettingsModel>(File.ReadAllText(filePath));
            WriteOut();
        }

        public void WriteOut() // Debugging method
        {
            
            var myAbbrevationList = File.ReadAllLines(Model.PathToFile)
                .Select(x => x.Split(':'))
                .ToDictionary(x => x[0], x => x[1]);
        }

        //public static Dictionary<string, string> ReadOutAbbrevations()
        //{
        //    //var myAbbList = new Dictionary<string, string>();

        //    // Check out Ellies way to handle Js

        //    myAbbList = File.ReadAllLines(@"c:\Users\magnus.eriksson\Dropbox\Abbreviations.txt")
        //        .Select(x => x.Split(':'))
        //        .ToDictionary(x => x[0], x => x[1]);

        //    foreach (KeyValuePair<string, string> item in myAbbList)
        //    {
        //        Debug.WriteLine("Value1: {0}, Value2: {1}", item.Key, item.Value);
        //    }

        //    return myAbbList;
        //}
    }
}
